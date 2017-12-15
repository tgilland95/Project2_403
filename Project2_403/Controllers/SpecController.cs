using Project2_403.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2_403.Controllers
{
    public class SpecController : Controller
    {
        private RepairsContext db = new RepairsContext();
        
        public ActionResult SpecSheet()
        {
            IEnumerable<DeviceReference> deviceReference =
                db.Database.SqlQuery<DeviceReference>(
            "SELECT * FROM DeviceReferences");


            return View(deviceReference);
        }
    }

}