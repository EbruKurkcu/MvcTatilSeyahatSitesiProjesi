using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog

        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            //var degerler = c.Blogs.ToList();
            by.Deger1 = c.Blogs.ToList();
            //Sondan başa doğru eklenen Blogları listelemek için OrderByDesceding kullanılıyor
            by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            //Ekranda 3 adet listelenmesi için Take kullanılmaktadır.
            by.Deger2 = c.Yorumlars.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(by);
        }

        
        public ActionResult BlogDetay(int id)
        {
            //Bloğun İd'si benim dışarıdan gönderdğim İd'ye eşit olan bloğun listesini gönder.
            //var degerler = c.Blogs.Where(x => x.ID == id).ToList();  
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();  //Blogları Listelemek
            by.Deger2 = c.Yorumlars.Where(x => x.BlogID == id).ToList(); //Yorumları Listelemek
            return View(by);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }


        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar p1)
        {
            c.Yorumlars.Add(p1);
            c.SaveChanges();
            return PartialView();
        }
    }
}