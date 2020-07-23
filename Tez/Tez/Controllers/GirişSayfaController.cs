using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Tez.Models;
namespace Tez.Controllers
{
    public class GirişSayfaController : Controller
    {
        // GET: GirişSayfa
        YöneticiModel db1 = new YöneticiModel();
        MüşteriModel db2 = new MüşteriModel();
        public ActionResult OrtakGiriş()
        {
            return View();
        }
        public ActionResult MüşteriGiriş()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MüşteriGiriş(Müşteri m)
        {
            var bilgi = db2.Müşteri.FirstOrDefault(x => x.Müşteri_KULLANICI == m.Müşteri_KULLANICI && x.Müşteri_ŞİFRE == m.Müşteri_ŞİFRE);
            if (bilgi != null)
            {
                return RedirectToAction("MüşteriListele", "Müşteriler");
            }
            else
            {
                return View();
            }
        }
        public ActionResult YöneticiGiriş()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YöneticiGiriş(Yönetici m1)
        {
            var bilgi2 = db1.Yönetici.FirstOrDefault(x => x.Yönetici_KULLANICI == m1.Yönetici_KULLANICI && x.Yönetici_ŞİFRE == m1.Yönetici_ŞİFRE);
            if (bilgi2 != null)
            {
                return RedirectToAction("MüşteriListele", "Müşteriler");
            }
            else
            {
                return View();
            }
        }
    }
}