using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcKutuphane.Controllers
{
    [Authorize]
    public class PanelimController : Controller
    {
        // GET: Panelim
        DBKÜTÜPHANEEntities db = new DBKÜTÜPHANEEntities();
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kitaplarım()
        {
            var degerler = db.TBLHAREKET.Where(x => x.ISLEMDURUM == true).ToList();
            return View(degerler);
        }
        
        public ActionResult Duyurular()
        {
            var duyurulistesi = db.TBLDUYURULAR.ToList();
            return View(duyurulistesi);
        }
        public ActionResult GelenMesajlar()
        {
            var mesajlistesi = db.TBLMESAJLAR.ToList();
            return View(mesajlistesi);
        }
        public ActionResult GidenMesajlar()
        {
            var mesajlistesi = db.TBLMESAJLAR.ToList();
            return View(mesajlistesi);
        }
        public ActionResult YeniMesaj()
        {
            var mesajlistesi = db.TBLMESAJLAR.ToList();
            return View(mesajlistesi);
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("GirisYap", "Login");
        }
    }
}