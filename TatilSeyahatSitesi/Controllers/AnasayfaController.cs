using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(4).ToList();
            return View(degerler);
        }

        public PartialViewResult Partial1()  //Sol ve Orta Resimler için kullanıldı.
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial2()  //Sağ Resim için kullanıldı.
        {
            var degerler = c.Blogs.Where(x => x.ID==1).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial3()  //En Popüler Liste sıralaması için kullanıldı.
        {
            var degerler = c.Blogs.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial4()  //En Beğendiğimiz kısmın sol tarafı için kullanıldı.
        {
            var degerler = c.Blogs.Take(3).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial5()  //En Beğendiğimiz kısmın sağ tarafı için kullanıldı.
        {
            var degerler = c.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(degerler);
        }
    }
}