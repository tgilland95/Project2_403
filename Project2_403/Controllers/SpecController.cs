using Project2_403.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2_403.Controllers
{
    [Authorize]
    public class SpecController : Controller
    {
        private RepairsContext db = new RepairsContext();
        
        public ActionResult SpecSheet()
        {
            //create device reference object and fill use SQL query to fill it with all data in the device reference table
            IEnumerable<DeviceReference> deviceReference =
                db.Database.SqlQuery<DeviceReference>(
            "SELECT * FROM DeviceReferences");


            //pass all device reference data to view
            return View(deviceReference);
        }
    }

}