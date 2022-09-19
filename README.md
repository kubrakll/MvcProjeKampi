# MvcProjeKampi
<h1>Proje Temelinin Atılması: </h1>
<h3>Proje dosyası oluşturma </h3><p>
  &nbsp;&nbsp; &nbsp;&nbsp;&nbsp; ASP.NET Web Application(.NET Framework) seçilir.<p>
  &nbsp;&nbsp; &nbsp;&nbsp;&nbsp; Gelen adımda MVC şablonu seçilir ve ismine MvcProjeKampi yazılır.(Sunum katmanımız istenirse sonuna UI eklenebilir.)<p>
 
<h3>Projemiz 4 katmanlı olacaktır. </h3><p>
<p>Entity Layer :  Sql tarafında yer alan tabloların satır ve sütunlarının yer aldığı kısım(Örnek: Başlık-Header veya Başlık ID gibi sütunlar.) <p>
DataAccess Layer: Veri erişim katmanı olarak geçer. CRUD işlemlerinin tamamı burada gerçekleşecek.(Cread Read Update Delete) <p>
Business Layer : Data Access tarafında projeye çekilmiş olan veriler bu katmanda işlenir. Kullanıcıdan gelen veriler önce Business katmanına gider oradan da             işlenerek Data Access katmanına aktarılır. Bu katmanda ayrıca bu verilere kimlerin erişeceğini belirtiyoruz. <p>
Presentation Layer-UI- User Interface: Sunum katmanı(MvcProjeKampi yazan kısım) <p>
    
<h3>Tablolarımız:</h3> <p>
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;- Heading<p> 
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;- Content <p>
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;- Writer <p>
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;- Contact <p>
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;- About <p>
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;- Category<p>
