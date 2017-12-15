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
    public class CustomerInfoController : Controller
    {
        private RepairsContext db = new RepairsContext();

        // GET: CustomerInfo
        public ActionResult Index()
        {
            return View(db.CustomerInfoRecords.ToList());
        }

        // GET: CustomerInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerInfoModel customerInfoModel = db.CustomerInfoRecords.Find(id);
            if (customerInfoModel == null)
            {
                return HttpNotFound();
            }
            return View(customerInfoModel);
        }

        // GET: CustomerInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerId,FirstName,LastName,PhoneNumber")] CustomerInfoModel customerInfoModel)
        {
            if (ModelState.IsValid)
            {
                db.CustomerInfoRecords.Add(customerInfoModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerInfoModel);
        }

        // GET: CustomerInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerInfoModel customerInfoModel = db.CustomerInfoRecords.Find(id);
            if (customerInfoModel == null)
            {
                return HttpNotFound();
            }
            return View(customerInfoModel);
        }

        // POST: CustomerInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerId,FirstName,LastName,PhoneNumber")] CustomerInfoModel customerInfoModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerInfoModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customerInfoModel);
        }

        // GET: CustomerInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerInfoModel customerInfoModel = db.CustomerInfoRecords.Find(id);
            if (customerInfoModel == null)
            {
                return HttpNotFound();
            }
            return View(customerInfoModel);
        }

        // POST: CustomerInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerInfoModel customerInfoModel = db.CustomerInfoRecords.Find(id);
            db.CustomerInfoRecords.Remove(customerInfoModel);
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
