using LoginA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LoginA.Controllers
{
    public class SecurityController : Controller
    {
        LoginDBContext ctx = new LoginDBContext();
        // GET: Security
        //Kullanıcı get yani hiç bir işlem yapmadığında sayfaya istek 
        //gönderdiğinde çalışan metot
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        //Kullanıcı post yani butona bastığında çalışan metod 
        [HttpPost]
        public ActionResult Login(tblAdmin log)
        {
            /*veri tabanında sorgulama yapıyor eğer ki kullanıcı var ise
             turu dönderiyor*/
            var kullanici = ctx.tblAdmins
               .FirstOrDefault(x => x.eposta == log.eposta && x.parola == log.parola);
            /*veritabanı sorgusunda kullanıcı dorğu bilgileri girerse 
             erişime izin veriliyor */
            if (kullanici != null)
            {
                //Kullanıcıyı aktif duruma getirerek engellenmiş sayfalara erişim izni
                //sağlanıyor bir diğer deyişle Authentction yapıyor
                FormsAuthentication.SetAuthCookie(kullanici.ad_soyad, false);
                //Kullanıcıyı belirtilen sayfaya yönlendiriyor
                return RedirectToAction("Index", "Home");
            }
            else
            {
                //Yanlış bilgi girildiğinde hata mesajı veriyor
                ViewBag.hata = "Hatalı Kullanıvı Adı veye Şifre Girdiniz";
                return View();
            }
        }
        //Oturumu kapatma metodu
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}