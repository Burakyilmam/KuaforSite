using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tez.Models;
namespace Tez.Controllers
{
    public class RandevuController : Controller
    {
        RandevuModel db = new RandevuModel();
        public ActionResult RandevuListele(string r)
        {
            var degerler = from d in db.Randevu select d;
            if (!string.IsNullOrEmpty(r))
            {
                degerler = degerler.Where(m => m.Randevu_AD.Contains(r));
            }
            return View(degerler.ToList());
        }
        [HttpGet]
        public ActionResult RandevuEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RandevuEkle(Randevu ra1)
        {
            db.Randevu.Add(ra1);
            db.SaveChanges();
            return RedirectToAction("RandevuEkle");
        }
        public ActionResult RandevuSil(int id)
        {
            var ra2 = db.Randevu.Find(id);
            db.Randevu.Remove(ra2);
            db.SaveChanges();
            return RedirectToAction("RandevuListele");
        }
        public ActionResult RandevuGetir(int id)
        {
            var ra3 = db.Randevu.Find(id);
            return View("RandevuGetir", ra3);

        }
        public ActionResult RandevuGüncelle(Randevu ra4)
        {
            var ra5 = db.Randevu.Find(ra4.Randevu_ID);
            ra5.Randevu_AD = ra4.Randevu_AD;
            ra5.Randevu_SOYAD = ra4.Randevu_SOYAD;
            ra5.Randevu_TEL = ra4.Randevu_TEL;
            ra5.Randevu_EPOSTA = ra4.Randevu_EPOSTA;
            ra5.Randevu_TÜR = ra4.Randevu_TÜR;
            ra5.Randevu_TARİH = ra4.Randevu_TARİH;
            ra5.Randevu_SAAT = ra4.Randevu_SAAT;
            db.SaveChanges();
            return RedirectToAction("RandevuListele");
        }
    }
}