﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication.DataAccess;

namespace WebApplication.Controllers
{
    public class AracController : Controller
    {
        private AmicaRentDBEntities db = new AmicaRentDBEntities();

        // GET: Arac
        public ActionResult Index()
        {
            return View(db.viewAracList.ToList());
        }

        // GET: Arac/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var arac = db.viewAracList.SingleOrDefault(x => x.Arac_ID == id);
            if (arac == null)
            {
                return HttpNotFound();
            }
            return View(arac);
        }

        // GET: Arac/Create
        public ActionResult Create()
        {

            List<AracGrup> aracGrupList = db.AracGrup.ToList();
            ViewBag.AracGrupList = aracGrupList;
            List<AracMarka> aracMarkaList = db.AracMarka.ToList();
            ViewBag.AracMarkaList = aracMarkaList;
            List<AracModel> aracModelList = db.AracModel.ToList();
            ViewBag.AracModelList = aracModelList;
            List<AracYakitTuru> aracYakitTuruList = db.AracYakitTuru.ToList();
            ViewBag.AracYakitTuruList = aracYakitTuruList;

            Dictionary<string, string> vitesTipi = new Dictionary<string, string>();
            vitesTipi.Add("OTOMATİK", "OTOMATİK");
            vitesTipi.Add("MANUEL", "MANUEL");
            ViewBag.VitesTipi = vitesTipi;

            List<AracKasaTipi> aracKasaTipiList = db.AracKasaTipi.ToList();
            ViewBag.AracKasaTipiList = aracKasaTipiList;

            Dictionary<int, string> aracKlimaDurumu = new Dictionary<int, string>();
            aracKlimaDurumu.Add(1, "Klimalı");
            aracKlimaDurumu.Add(2, "Klimasız");
            ViewBag.AracKlimaDurumu = aracKlimaDurumu;

            List<AracRenk> aracRenkList = db.AracRenk.ToList();
            ViewBag.AracRenkList = aracRenkList;


            Dictionary<int, string> aracKiralamaDurumu = new Dictionary<int, string>();
            aracKiralamaDurumu.Add(0, "Boşta");
            aracKiralamaDurumu.Add(1, "Müşteride");
            aracKiralamaDurumu.Add(2, "Pasif Araç");
            aracKiralamaDurumu.Add(3, "Arızalı/Serviste");
            ViewBag.AracKiralamaDurumu = aracKiralamaDurumu;



            return View();
        }

        // POST: Arac/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Arac_ID,AracGrup_ID,AracMarka_ID,AracModel_ID,Arac_Yil,AracYakitTuru_ID,Arac_VitesTipi,AracKasaTipi_ID,AracKlimaDurumu,AracPlakaNo,AracGuncelKM,AracMotorNo,AracSaseNo,AracRuhsatSeriNo,Arac_Status,AracRenk_ID,AracKiralamaDurumu,Arac_TrafikSigortasiBitisTarihi,Arac_KaskoBitisTarihi,Arac_KoltukSigortasiBitisTarihi,Arac_FenniMuayeneGecerlilikTarihi")] Arac arac)
        {
            if (ModelState.IsValid)
            {
                db.Arac.Add(arac);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(arac);
        }

        // GET: Arac/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arac arac = db.Arac.Find(id);
            if (arac == null)
            {
                return HttpNotFound();
            }

            List<AracGrup> aracGrupList = db.AracGrup.ToList();
            ViewBag.AracGrupList = aracGrupList;
            List<AracMarka> aracMarkaList = db.AracMarka.ToList();
            ViewBag.AracMarkaList = aracMarkaList;
            List<AracModel> aracModelList = db.AracModel.ToList();
            ViewBag.AracModelList = aracModelList;
            List<AracYakitTuru> aracYakitTuruList = db.AracYakitTuru.ToList();
            ViewBag.AracYakitTuruList = aracYakitTuruList;

            Dictionary<string, string> vitesTipi = new Dictionary<string, string>();
            vitesTipi.Add("OTOMATİK", "OTOMATİK");
            vitesTipi.Add("MANUEL", "MANUEL");
            ViewBag.VitesTipi = vitesTipi;

            List<AracKasaTipi> aracKasaTipiList = db.AracKasaTipi.ToList();
            ViewBag.AracKasaTipiList = aracKasaTipiList;

            Dictionary<int, string> aracKlimaDurumu = new Dictionary<int, string>();
            aracKlimaDurumu.Add(1, "Klimalı");
            aracKlimaDurumu.Add(2, "Klimasız");
            ViewBag.AracKlimaDurumu = aracKlimaDurumu;

            List<AracRenk> aracRenkList = db.AracRenk.ToList();
            ViewBag.AracRenkList = aracRenkList;


            Dictionary<int, string> aracKiralamaDurumu = new Dictionary<int, string>();
            aracKiralamaDurumu.Add(0, "Boşta");
            aracKiralamaDurumu.Add(1, "Müşteride");
            aracKiralamaDurumu.Add(2, "Pasif Araç");
            aracKiralamaDurumu.Add(3, "Arızalı/Serviste");

            ViewBag.AracKiralamaDurumu = aracKiralamaDurumu;


            return View(arac);
        }

        // POST: Arac/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Arac_ID,AracGrup_ID,AracMarka_ID,AracModel_ID,Arac_Yil,AracYakitTuru_ID,Arac_VitesTipi,AracKasaTipi_ID,AracKlimaDurumu,AracPlakaNo,AracGuncelKM,AracMotorNo,AracSaseNo,AracRuhsatSeriNo,Arac_Status,AracRenk_ID,AracKiralamaDurumu,Arac_TrafikSigortasiBitisTarihi,Arac_KaskoBitisTarihi,Arac_KoltukSigortasiBitisTarihi,Arac_FenniMuayeneGecerlilikTarihi")] Arac arac)
        {
            if (ModelState.IsValid)
            {
                db.Entry(arac).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(arac);
        }

        // GET: Arac/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Arac arac = db.Arac.Find(id);
            if (arac == null)
            {
                return HttpNotFound();
            }
            return View(arac);
        }

        // POST: Arac/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Arac arac = db.Arac.Find(id);
            db.Arac.Remove(arac);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
