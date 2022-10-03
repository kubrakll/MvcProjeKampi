using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules_FluenValidation_;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class IstatistikController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        CategoryValidator categoryvalidator = new CategoryValidator();

        WriterManager wm = new WriterManager(new EfWriterDal());
        WriterValidator writervalidator=new WriterValidator();


       
        public ActionResult Index()
        {
            var CategoryValues = cm.GetList();   
            return View(CategoryValues);
            
            
        }

       
        //public ActionResult Index(Writer p)
        //{
        //    var WriterValues = wm.GetListe();
        //    return View(WriterValues);

        //}


    }
}