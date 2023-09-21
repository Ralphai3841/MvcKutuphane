using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models;
using MvcKutuphane.Models.Entity;


namespace MvcKutuphane.Controllers
{
    public class GrafikController : Controller
    {
        // GET: Grafik
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VisualizeKitapResult()
        {
            return Json(liste());
        }
        public List<Class1> liste()
        {
            List<Class1> cs = new List<Class1>();
            cs.Add(new Class1()
            {
                yayinevi = "İş Bankası Yayınları",
                sayi = 44
            });
            cs.Add(new Class1()
            {
                yayinevi = "Can Yayınları",
                sayi = 17
            });
            cs.Add(new Class1()
            {
                yayinevi = "İthaki Yayınları",
                sayi = 25
            });
            cs.Add(new Class1()
            {
                yayinevi = "Artemis Yayınları",
                sayi = 2
            });
            cs.Add(new Class1()
            {
                yayinevi = "Kırmızı Kedi Yayınevi",
                sayi = 3
            });
            cs.Add(new Class1()
            {
                yayinevi = "Altın Kitap Yayınevi",
                sayi = 13
            });
            cs.Add(new Class1()
            {
                yayinevi = "Bilgi Yayınevi",
                sayi = 1
            });
            cs.Add(new Class1()
            {
                yayinevi = "Roman Yayınevi",
                sayi = 5
            });
            cs.Add(new Class1()
            {
                yayinevi = "YKY Yayınevi",
                sayi = 4
            });
            cs.Add(new Class1()
            {
                yayinevi = "İletişim Yayınları",
                sayi = 5
            });
            cs.Add(new Class1()
            {
                yayinevi = "Say Yayınları",
                sayi = 3
            });
            cs.Add(new Class1()
            {
                yayinevi = "Ötüken Neşriyat",
                sayi = 5
            });
            cs.Add(new Class1()
            {
                yayinevi = "Epsilon Yayınevi",
                sayi = 5
            });
            cs.Add(new Class1()
            {
                yayinevi = "Doğan Kitap Yayınevi",
                sayi = 5
            });
            cs.Add(new Class1()
            {
                yayinevi = "Tübitak Yayınevi",
                sayi = 2
            });
            cs.Add(new Class1()
            {
                yayinevi = "Ekinoks Yayınevi",
                sayi = 1
            });
            cs.Add(new Class1()
            {
                yayinevi = "TİMAŞ Yayınevi",
                sayi = 5
            });
            cs.Add(new Class1()
            {
                yayinevi = "April Yayıncılık",
                sayi = 1
            });
            cs.Add(new Class1()
            {
                yayinevi = "Everest Yayınları",
                sayi = 1
            });
            cs.Add(new Class1()
            {
                yayinevi = "E Yayınları",
                sayi = 3
            });
            return cs;
        }
    }
}