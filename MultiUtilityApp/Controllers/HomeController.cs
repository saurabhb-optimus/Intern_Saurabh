using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ITFinder.BLL;
using Newtonsoft.Json;

namespace MultiUtilityApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult FindIT()
        {

         
            return View();

        }



        [HttpPost]
        public ActionResult DisplayIt(string location)
        {
            ViewBag.Location = location;
            System.Diagnostics.Debug.WriteLine(location);
            FormatOutput f = new FormatOutput();
            List<Company> resultCompany = f.GetResults(location);

            if (!resultCompany.Equals(null))
            {
                return View(resultCompany);
            }
            return View();
        }
        
    }
}