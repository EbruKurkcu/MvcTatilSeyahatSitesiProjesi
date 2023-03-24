using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();

       // Hangi alanı kısıtlamak , erişime kapatmak istiyorsak
       // o kısma ise[Authorize] etiketi getirerek kullanıcını
       // Index sayfasına girişini oturum işleminin ardından mümkün olabileceğini söylüyor.

        [Authorize]
        public ActionResult Index()  //Listeleme Kodu
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var degerler = c.Blogs.Find(id);
            c.Blogs.Remove(degerler);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogGetir(int id)
        {
            var degerler = c.Blogs.Find(id);
            return View("BlogGetir",degerler);
        }

        public ActionResult Guncelle(Blog p1)
        {
            var degerler = c.Blogs.Find(p1.ID);
            degerler.Aciklama = p1.Aciklama;
            degerler.Baslik = p1.Baslik;
            degerler.BlogImage = p1.BlogImage;
            degerler.Tarih = p1.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YorumListesi()
        {
            var degerler = c.Yorumlars.ToList();
            return View(degerler);
        }

        public ActionResult YorumSil(int id)
        {
            var degerler = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(degerler);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumGetir(int id)
        {
            var degerler = c.Yorumlars.Find(id);
            return View("YorumGetir",degerler);
        }

        public ActionResult YorumGuncelle(Yorumlar p1)
        {
            var degerler = c.Yorumlars.Find(p1.ID);
            degerler.ID = p1.ID;
            degerler.KullaniciAdi = p1.KullaniciAdi;
            degerler.Mail = p1.Mail;
            degerler.Yorum = p1.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}