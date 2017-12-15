using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Data.Sql;
using Project2_403.Models;


namespace Project2_403.Controllers
{


    public class RepairHubController : Controller
    {
        private RepairsContext db = new RepairsContext();
        


        // GET: RepairHub
        public ActionResult Index()
        {
            
            return View();
        }



        

        // GET: RepairHub/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RepairHub/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RepairHub/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RepairHub/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RepairHub/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RepairHub/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
