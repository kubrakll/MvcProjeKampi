using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        // Önce listeleme işlemi yapmak için

        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm=new WriterManager(new EfWriterDal());
        

        public ActionResult Index()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();

            List<SelectListItem> valuewriter = (from y in wm.GetListe()
                                                select new SelectListItem
                                                {
                                                    Text = y.WriterName + " " + y.WriterSurName,
                                                    Value = y.WriterID.ToString()

                                                }).ToList();

            ViewBag.vlc = valuecategory;
            ViewBag.vlw = valuewriter;
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult ContentByHeading()
        {
            return View();
        }
    }
}
//Valuenumber seçmiş olduğum değerin id si
//displaynumber seçmiş olduğum değerin kendisi