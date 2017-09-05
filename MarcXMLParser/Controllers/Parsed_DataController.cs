using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MarcXMLParser.Models;

namespace MarcXMLParser.Controllers
{
    public class Parsed_DataController : Controller
    {
        private MARC_XML db = new MARC_XML();

        // GET: Parsed_Data
        public ActionResult Index()
        {
            return View(db.tbl_Parsed_Data.ToList());
        }

        // GET: Parsed_Data/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Parsed_Data tbl_Parsed_Data = db.tbl_Parsed_Data.Find(id);
            if (tbl_Parsed_Data == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Parsed_Data);
        }

        // GET: Parsed_Data/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parsed_Data/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,leader,controlfield_003,controlfield_005,controlfield_008,datafield_020_a,datafield_022_a,datafield_035_a,datafield_040_a,datafield_040_b,datafield_040_c,datafield_040_d,datafield_040_e,datafield_041_a,datafield_041_h,datafield_044_a,datafield_080_a,datafield_100_4,datafield_100_a,datafield_110_a,datafield_110_c,datafield_245_a,datafield_245_b,datafield_245_c,datafield_245_n,datafield_245_p,datafield_260_a,datafield_260_b,datafield_260_c,datafield_300_a,datafield_300_b,datafield_300_c,datafield_310_a,datafield_362_a,datafield_440_a,datafield_440_v,datafield_490_a,datafield_490_v,datafield_500_a,datafield_504_a,datafield_505_a,datafield_520_a,datafield_546_a,datafield_550_a,datafield_555_a,datafield_653_a,datafield_700_4,datafield_700_9,datafield_700_a,datafield_740_a,datafield_776_t,datafield_776_x,datafield_780_t,datafield_780_x,datafield_830_a,datafield_830_n,datafield_830_p,datafield_830_v,datafield_856_u,datafield_856_z,datafield_942_6,datafield_942_b,datafield_942_c,datafield_942_d,datafield_942_h,datafield_942_i,datafield_942_t,datafield_942_u,datafield_952_0,datafield_952_1,datafield_952_4,datafield_952_6,datafield_952_7,datafield_952_8,datafield_952_9,datafield_952_a,datafield_952_b,datafield_952_c,datafield_952_d,datafield_952_e,datafield_952_g,datafield_952_h,datafield_952_i,datafield_952_l,datafield_952_m,datafield_952_o,datafield_952_p,datafield_952_q,datafield_952_r,datafield_952_s,datafield_952_t,datafield_952_v,datafield_952_w,datafield_952_y,datafield_952_z,datafield_991_a,datafield_992_a,datafield_992_b,datafield_992_c,datafield_992_d,datafield_992_e,datafield_999_c,datafield_999_d")] tbl_Parsed_Data tbl_Parsed_Data)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Parsed_Data.Add(tbl_Parsed_Data);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Parsed_Data);
        }

        // GET: Parsed_Data/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Parsed_Data tbl_Parsed_Data = db.tbl_Parsed_Data.Find(id);
            if (tbl_Parsed_Data == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Parsed_Data);
        }

        // POST: Parsed_Data/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,leader,controlfield_003,controlfield_005,controlfield_008,datafield_020_a,datafield_022_a,datafield_035_a,datafield_040_a,datafield_040_b,datafield_040_c,datafield_040_d,datafield_040_e,datafield_041_a,datafield_041_h,datafield_044_a,datafield_080_a,datafield_100_4,datafield_100_a,datafield_110_a,datafield_110_c,datafield_245_a,datafield_245_b,datafield_245_c,datafield_245_n,datafield_245_p,datafield_260_a,datafield_260_b,datafield_260_c,datafield_300_a,datafield_300_b,datafield_300_c,datafield_310_a,datafield_362_a,datafield_440_a,datafield_440_v,datafield_490_a,datafield_490_v,datafield_500_a,datafield_504_a,datafield_505_a,datafield_520_a,datafield_546_a,datafield_550_a,datafield_555_a,datafield_653_a,datafield_700_4,datafield_700_9,datafield_700_a,datafield_740_a,datafield_776_t,datafield_776_x,datafield_780_t,datafield_780_x,datafield_830_a,datafield_830_n,datafield_830_p,datafield_830_v,datafield_856_u,datafield_856_z,datafield_942_6,datafield_942_b,datafield_942_c,datafield_942_d,datafield_942_h,datafield_942_i,datafield_942_t,datafield_942_u,datafield_952_0,datafield_952_1,datafield_952_4,datafield_952_6,datafield_952_7,datafield_952_8,datafield_952_9,datafield_952_a,datafield_952_b,datafield_952_c,datafield_952_d,datafield_952_e,datafield_952_g,datafield_952_h,datafield_952_i,datafield_952_l,datafield_952_m,datafield_952_o,datafield_952_p,datafield_952_q,datafield_952_r,datafield_952_s,datafield_952_t,datafield_952_v,datafield_952_w,datafield_952_y,datafield_952_z,datafield_991_a,datafield_992_a,datafield_992_b,datafield_992_c,datafield_992_d,datafield_992_e,datafield_999_c,datafield_999_d")] tbl_Parsed_Data tbl_Parsed_Data)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Parsed_Data).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Parsed_Data);
        }

        // GET: Parsed_Data/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Parsed_Data tbl_Parsed_Data = db.tbl_Parsed_Data.Find(id);
            if (tbl_Parsed_Data == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Parsed_Data);
        }

        // POST: Parsed_Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Parsed_Data tbl_Parsed_Data = db.tbl_Parsed_Data.Find(id);
            db.tbl_Parsed_Data.Remove(tbl_Parsed_Data);
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
