using System.Web.Mvc;

public class HomeController : Controller
{
    public ActionResult AnaEkran()
    {
        // Giriş yapmış kullanıcı bilgilerini kontrol edebilirsiniz.
        if (Session["KullanıcıID"] == null)
        {
            return RedirectToAction("Index", "Login");
        }

        ViewBag.KullanıcıAdSoyad = Session["KullanıcıAdSoyad"];
        return View();
    }
}