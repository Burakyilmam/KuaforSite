using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tez.Models;
namespace Tez.Controllers
{
    public class KayitSayfaController : Controller
    {
        MüşteriModel db = new MüşteriModel();
        public ActionResult Kayit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kayit(Müşteri m1)
        {
            db.Müşteri.Add(m1);
            db.SaveChanges();
            return RedirectToAction("Kayit");
        }
    }
    
}