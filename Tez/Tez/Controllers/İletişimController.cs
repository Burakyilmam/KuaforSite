using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tez.Models;
namespace Tez.Controllers
{
    public class İletişimController : Controller
    {
        İletisimModel db1 = new İletisimModel();
        public ActionResult İletişim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult İletişim(İletisim i1)
        {
            db1.İletisim.Add(i1);
            db1.SaveChanges();
            return RedirectToAction("İletişim");
        }
        public ActionResult İletişimListele(string i)
        {
            var degerler = from d in db1.İletisim select d;
            if (!string.IsNullOrEmpty(i))
            {
                degerler = degerler.Where(m => m.İletisim_AD.Contains(i));
            }
            return View(degerler.ToList());
        }
    }
}