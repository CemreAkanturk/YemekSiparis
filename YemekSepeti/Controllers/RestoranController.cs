using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSepeti.Models;

namespace YemekSepeti.Controllers
{
    public class RestoranController : Controller
    {
        TasarımEntities db = new TasarımEntities();
        // GET: Restoran
        public ActionResult Index()
        {
            
            Index model = new Index();
            var Uye = db.Uye.Find(1);
            model.uye = Uye;
            model.yenirestoranlar = db.Restoran.ToList() ;
            model.adreslerim = db.Adres.Where(x => x.UyeId == 1).ToList();
            model.siparislerim = db.Siparis.Where(x => x.UyeId == 1).ToList();
            return View(model);
        }


        public ActionResult RestoranSayfa(int id)
        {
            RestoranVM model = new RestoranVM();
            var secilen = db.Restoran.Find(id);
            var uye = db.Uye.Find(1);
            model.restoran = secilen;
            model.yorumlar = db.Yorum.Where(x => x.RestoranId == id).ToList();
            var urunler = db.Urun.Where(x => x.RestoranId == id).ToList();
            model.urunlerListesi = urunler;
            model.uye = uye;
            return View(model);
        }

        public ActionResult Onayla()
        {
       
            return View();
        }


        [HttpPost]
        public JsonResult Icerik(int Id)
        {
            var secilenicerik = db.Urun_Icerik.Where(x => x.UrunId == Id).ToList();
           
            return Json(secilenicerik, JsonRequestBehavior.AllowGet);

        }
    }
}