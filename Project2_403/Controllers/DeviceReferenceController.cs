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
    [Authorize]
    public class DeviceReferenceController : Controller
    {
        private RepairsContext db = new RepairsContext();

        // GET: DeviceReference
        public ActionResult Index()
        {
            return View(db.deviceReference.ToList());
        }

        // GET: DeviceReference/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeviceReference deviceReference = db.deviceReference.Find(id);
            if (deviceReference == null)
            {
                return HttpNotFound();
            }
            return View(deviceReference);
        }

        // GET: DeviceReference/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeviceReference/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DeviceReferenceId,DeviceModel,DeviceBrand,DeviceColor,DeviceCapacity,DeviceBattery,DeviceDescription")] DeviceReference deviceReference)
        {
            if (ModelState.IsValid)
            {
                db.deviceReference.Add(deviceReference);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(deviceReference);
        }

        // GET: DeviceReference/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeviceReference deviceReference = db.deviceReference.Find(id);
            if (deviceReference == null)
            {
                return HttpNotFound();
            }
            return View(deviceReference);
        }

        // POST: DeviceReference/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DeviceReferenceId,DeviceModel,DeviceBrand,DeviceColor,DeviceCapacity,DeviceBattery,DeviceDescription")] DeviceReference deviceReference)
        {
            if (ModelState.IsValid)
            {
                db.Entry(deviceReference).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(deviceReference);
        }

        // GET: DeviceReference/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeviceReference deviceReference = db.deviceReference.Find(id);
            if (deviceReference == null)
            {
                return HttpNotFound();
            }
            return View(deviceReference);
        }

        // POST: DeviceReference/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DeviceReference deviceReference = db.deviceReference.Find(id);
            db.deviceReference.Remove(deviceReference);
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
