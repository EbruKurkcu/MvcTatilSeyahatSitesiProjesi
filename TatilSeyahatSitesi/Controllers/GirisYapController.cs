using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Security;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        Context c = new Context();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]  //Kullanıcı Adı ve Şifre bilgilerini girip butona bastığımızda HttpPost çalışacak
        public ActionResult Login(Admin p1)
        {
            //Veritabanındaki Kullanıcı Adı ve Şifre Bilgileri kullanıcının giriği(p1) değer ile uyuşuyorsa websiteye giriş yapılabilecek.

            var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanici == p1.Kullanici &&  x.Sifre == p1.Sifre);

            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici, false);
                Session["Kullanici"] = bilgiler.Kullanici.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();  //Oturumu Kapat
            return RedirectToAction("Login","GirisYap");

        }
    }
}