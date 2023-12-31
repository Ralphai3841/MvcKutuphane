﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;
using System.Web.Security;

namespace MvcKutuphane.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        DBKÜTÜPHANEEntities db = new DBKÜTÜPHANEEntities();
        public ActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GirisYap(TBLUYELER p)
        {
            var bilgiler = db.TBLUYELER.FirstOrDefault(x => x.MAIL == p.MAIL && x.SIFRE == p.SIFRE);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.MAIL, false);
                Session["id"] = bilgiler.ID.ToString();
                Session["Ad"] = bilgiler.AD.ToString();
                Session["Soyad"] = bilgiler.SOYAD.ToString();
                Session["Kullanıcı Adı"] = bilgiler.KULLANICIADI.ToString();
                Session["Şifre"] = bilgiler.SIFRE.ToString();
                Session["Okul"] = bilgiler.OKUL.ToString();
                return RedirectToAction("Index", "Panelim");
            }
            else
            {
                return View();
            }

        }
    }
}