using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tez.Models;
namespace Tez.Controllers
{
    public class YorumlarController : Controller
    {
        YorumModel db = new YorumModel();
        public ActionResult Yorumlar()
            {
                var y1 = db.Yorum.ToList();
                return View(y1);
            }
        public ActionResult YorumEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YorumEkle(Yorum yo1)
        {
            db.Yorum.Add(yo1);
            db.SaveChanges();
            return RedirectToAction("Yorumlar");
        }
        public ActionResult YorumListele(string y)
        {
            var degerler = from d in db.Yorum select d;
            if (!string.IsNullOrEmpty(y))
            {
                degerler = degerler.Where(m => m.Yorum_AD.Contains(y));
            }
            return View(degerler.ToList());
        }
        public ActionResult YorumSil(int id)
        {
            var yo2 = db.Yorum.Find(id);
            db.Yorum.Remove(yo2);
            db.SaveChanges();
            return RedirectToAction("YorumListele");
        }
        public ActionResult YorumGetir(int id)
        {
            var yo3 = db.Yorum.Find(id);
            return View("YorumGetir", yo3);

        }
        public ActionResult YorumGüncelle(Yorum yo4)
        {
            var yo5 = db.Yorum.Find(yo4.Yorum_ID);
            yo5.Yorum_AD = yo4.Yorum_AD;
            yo5.Yorum_SOYAD = yo4.Yorum_SOYAD;
            yo5.Yorum_TARİH = yo4.Yorum_TARİH;
            yo5.Hizmet_Türü = yo4.Hizmet_Türü;
            yo5.Yorum_YORUM = yo4.Yorum_YORUM;
            db.SaveChanges();
            return RedirectToAction("YorumListele");
        }
    }
}