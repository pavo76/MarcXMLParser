using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MarcXMLParser.Models;
using MarcXMLParser.HelperClasses;

namespace MarcXMLParser.Controllers
{
    public class ParserController : Controller
    {
        private MARC_XML db = new MARC_XML();

        // GET: Parser
        public ActionResult Index()
        {
            return View(db.MARC_XML_.ToList());
        }

        // GET: Parser/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MARC_XML_ mARC_XML_ = db.MARC_XML_.Find(id);
            if (mARC_XML_ == null)
            {
                return HttpNotFound();
            }
            Dict dict = new Dict();
            dict.Dictionary = ParserDict.Parse(mARC_XML_.XML);
            return View(dict);
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
        public ActionResult Create([Bind(Include = "ID,ID_Broj_Knjige,XML,Datum_preuzimanja")] MARC_XML_ mARC_XML_)
        {
            if (ModelState.IsValid)
            {
                db.MARC_XML_.Add(mARC_XML_);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mARC_XML_);
        }

        // GET: Parser/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MARC_XML_ mARC_XML_ = db.MARC_XML_.Find(id);
            if (mARC_XML_ == null)
            {
                return HttpNotFound();
            }
            return View(mARC_XML_);
        }

        // POST: Parser/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ID_Broj_Knjige,XML,Datum_preuzimanja")] MARC_XML_ mARC_XML_)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mARC_XML_).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mARC_XML_);
        }

        // GET: Parser/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MARC_XML_ mARC_XML_ = db.MARC_XML_.Find(id);
            if (mARC_XML_ == null)
            {
                return HttpNotFound();
            }
            return View(mARC_XML_);
        }

        // POST: Parser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MARC_XML_ mARC_XML_ = db.MARC_XML_.Find(id);
            db.MARC_XML_.Remove(mARC_XML_);
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
