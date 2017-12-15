using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2_403.Models;

/*
    This project is designed to simplify the device repair process for Tricked Out Accessories, a phone accessories and repair company.
    Their current system only uses paper documents and is very unorganized.  This application should allow employees to enter repair forms with
    information about the devices they are repairing and the customers who own those devices.  It should also allow managers to see all repairs
    in progress and allow them to update their knowledge base (Or Tech Specs) of phones.

    All users are required to login before viewing any of this data - either through individual logins or through OAuth - because this is not a
    client-facing application.  It is solely for the use of company employees

*/


namespace Project2_403.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}