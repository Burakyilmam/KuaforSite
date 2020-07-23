using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tez.Models;
namespace Tez.Controllers
{
    public class MüşterilerController : Controller
    {
        // TezEntities2 db = new TezEntities2();
        MüşteriModel db = new MüşteriModel();
        public ActionResult MüşteriListele(string p)
        {
            var degerler = from d in db.Müşteri select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.Müşteri_AD.Contains(p));
            }
            return View(degerler.ToList());
        }
        [HttpGet]
        public ActionResult MüşteriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MüşteriEkle(Müşteri mü1)
        {
            db.Müşteri.Add(mü1);
            db.SaveChanges();
            return RedirectToAction("MüşteriListele");
        }
        public ActionResult MüşteriSil(int id)
        {
            var mü2 = db.Müşteri.Find(id);
            db.Müşteri.Remove(mü2);
            db.SaveChanges();
            return RedirectToAction("MüşteriListele");
        }
        public ActionResult MüşteriGetir(int id)
        {
            var mü3 = db.Müşteri.Find(id);
            return View("MüşteriGetir",mü3);

        }
        public ActionResult MüşteriGüncelle(Müşteri mü4)
        {
            var mü5 = db.Müşteri.Find(mü4.Müşteri_ID);
            mü5.Müşteri_AD = mü4.Müşteri_AD;
            mü5.Müşteri_SOYAD = mü4.Müşteri_SOYAD;
            mü5.Müşteri_KULLANICI = mü4.Müşteri_KULLANICI;
            mü5.Müşteri_ŞİFRE = mü4.Müşteri_ŞİFRE;
            mü5.Müşteri_TEL = mü4.Müşteri_TEL;
            mü5.Müşteri_EPOSTA = mü4.Müşteri_EPOSTA;
            db.SaveChanges();
            return RedirectToAction("MüşteriListele");
        }
    }
}