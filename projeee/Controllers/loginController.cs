using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projeee.Models;

namespace projeee.Controllers
{
    public class loginController : Controller
    {
        projesqlEntities entity = new projesqlEntities();
        public ActionResult Index()
        {
            ViewBag.mesaj = null;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Email, string parola)
        {
            var kullanicilar = (from k in entity.Kullancılar
                                where k.ePosta == Email && k.şifre == parola
                                select k).FirstOrDefault();
            if (kullanicilar != null)
            {
                Session["KullanıcıAdSoyad"] = kullanicilar.kullaniciAdı;
                Session["KullanıcıID"] = kullanicilar.kullanıcıID;
                Session["KullanıcıYetkiTurID"] = kullanicilar.yetkiTürüID;

                switch (kullanicilar.yetkiTürüID)
                {
                    case 1:
                        return RedirectToAction("Index", "Yönetici");
                    case 2:
                        return RedirectToAction("AnaEkran", "Home"); // Ana ekran yönlendirmesi
                    default:
                        ViewBag.mesaj = "Yetkiniz bulunmamaktadır.";
                        return View();
                }

            }
            else
            {
                ViewBag.mesaj = "E-posta veya Şifre yanlış";
                return View();
            }
        }
    


    public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Şifre ve Şifre Tekrar uyuşuyor mu kontrol edin
                if (model.Parola != model.ParolaTekrar)
                {
                    ViewBag.mesaj = "Şifreler uyuşmuyor.";
                    return View();
                }

                // Kullanıcı daha önce kayıtlı mı kontrol edin
                var mevcutKullanici = entity.Kullancılar.FirstOrDefault(k => k.ePosta == model.Email);
                if (mevcutKullanici != null)
                {
                    ViewBag.mesaj = "Bu e-posta adresi zaten kayıtlı.";
                    return View();
                }

                // Yeni kullanıcı oluştur ve kaydet
                Kullancılar yeniKullanici = new Kullancılar
                {
                    kullaniciAdı = model.KullaniciAdi,
                    ePosta = model.Email,
                    şifre = model.Parola,
                    yetkiTürüID = 2 // Varsayılan yetki türü (normal kullanıcı)
                };

                entity.Kullancılar.Add(yeniKullanici);
                entity.SaveChanges();

                // Başarılı kayıt sonrası yönlendirme
                return RedirectToAction("Index", "Login");
            }

            ViewBag.mesaj = "Tüm alanları doldurduğunuzdan emin olun.";
            return View();
        }
    }

}