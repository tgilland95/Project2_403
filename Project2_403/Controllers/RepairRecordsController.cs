using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project2_403.Models;

namespace Project2_403.Controllers
{
    public class RepairRecordsController : Controller
    {
        private RepairsContext db = new RepairsContext();

        // GET: RepairRecords
        public ActionResult Index()
        {
            return View(db.Repair.ToList());
        }

        // GET: RepairRecords/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepairRecord repairRecord = db.Repair.Find(id);
            if (repairRecord == null)
            {
                return HttpNotFound();
            }
            return View(repairRecord);
        }

        // GET: RepairRecords/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RepairRecords/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RepairRecordId,RepairStatus,RepairComments")] RepairRecord repairRecord)
        {
            if (ModelState.IsValid)
            {
                db.Repair.Add(repairRecord);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(repairRecord);
        }

        // GET: RepairRecords/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepairRecord repairRecord = db.Repair.Find(id);
            if (repairRecord == null)
            {
                return HttpNotFound();
            }
            return View(repairRecord);
        }

        // POST: RepairRecords/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RepairRecordId,RepairStatus,RepairComments")] RepairRecord repairRecord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(repairRecord).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(repairRecord);
        }

        // GET: RepairRecords/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepairRecord repairRecord = db.Repair.Find(id);
            if (repairRecord == null)
            {
                return HttpNotFound();
            }
            return View(repairRecord);
        }

        // POST: RepairRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RepairRecord repairRecord = db.Repair.Find(id);
            db.Repair.Remove(repairRecord);
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
