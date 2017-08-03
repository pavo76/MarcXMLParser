using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MarcXMLParser.Models;
using System.Xml.Linq;
using MarcXMLParser.HelperClasses;
using System.IO;

namespace MarcXMLParser.Controllers
{
    public class ParserController : Controller
    {
        private XML db = new XML();

        // GET: Parser
        public ActionResult Index()
        {
            return View(db.MARC_XML.ToList());
        }

        // GET: Parser/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MARC_XML mARC_XML = db.MARC_XML.Find(id);
            if (mARC_XML == null)
            {
                return HttpNotFound();
            }

            Record record= Parser.Parse(mARC_XML.XML);
            return View(record);
        }

        // GET: Parser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parser/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ID_Broj_Knjige,XML,Datum_preuzimanja")] MARC_XML mARC_XML)
        {
            if (ModelState.IsValid)
            {
                db.MARC_XML.Add(mARC_XML);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mARC_XML);
        }

        // GET: Parser/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MARC_XML mARC_XML = db.MARC_XML.Find(id);
            if (mARC_XML == null)
            {
                return HttpNotFound();
            }
            return View(mARC_XML);
        }

        // POST: Parser/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ID_Broj_Knjige,XML,Datum_preuzimanja")] MARC_XML mARC_XML)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mARC_XML).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mARC_XML);
        }

        // GET: Parser/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MARC_XML mARC_XML = db.MARC_XML.Find(id);
            if (mARC_XML == null)
            {
                return HttpNotFound();
            }
            return View(mARC_XML);
        }

        // POST: Parser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MARC_XML mARC_XML = db.MARC_XML.Find(id);
            db.MARC_XML.Remove(mARC_XML);
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
