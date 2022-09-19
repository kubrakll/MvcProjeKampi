# MvcProjeKampi
Adım Adım Proje Temelinin Atılması: 
1.Adım: Proje dosyası oluşturma 
  ASP.NET Web Application(.NET Framework) seçilir.
  Gelen adımda MVC şablonu seçilir ve ismine MvcProjeKampi yazılır.(Sunum katmanımız istenirse sonuna UI eklenebilir.)
 
Projemiz 4 katmanlı olacaktır. 
    Entity Layer :  Sql tarafında yer alan tabloların satır ve sütunlarının yer aldığı kısım(Örnek: Başlık-Header veya Başlık ID gibi sütunlar.) 
    DataAccess Layer: Veri erişim katmanı olarak geçer. CRUD işlemlerinin tamamı burada gerçekleşecek.(Cread Read Update Delete) 
    Business Layer : Data Access tarafında projeye çekilmiş olan veriler bu katmanda işlenir. Kullanıcıdan gelen veriler önce Business katmanına gider oradan da             işlenerek Data Access katmanına aktarılır. Bu katmanda ayrıca bu verilere kimlerin erişeceğini belirtiyoruz. 
    Presentation Layer-UI- User Interface: Sunum katmanı(MvcProjeKampi yazan kısım) 
    
Tablolarımız: 
    Heading 
    Content 
    Writer 
    Contact 
    About 
    Category
