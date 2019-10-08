using BuckeyeLawnServices.Models;
using Microsoft.AspNetCore.Mvc;
using System;


namespace BuckeyeLawnServices.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            //ViewBag.Greeting = hour < 12 ? "Good Morning," : "Good Afternoon,";

            if (hour > 17)
            {
                ViewBag.Greeting = "Good Evening,";
            }
            else if (hour > 12)
            {
                ViewBag.Greeting = "Good Afternoon,";
            }
            else
            {
                ViewBag.Greeting = "Good Morning,";
            }


            return View("HomePage");
        }

        [HttpGet]
        public ViewResult NewRequest()
        {
            return View();
        }

        [HttpPost]
        public ViewResult NewRequest(NewCustomerRequest newCustomerRequest)
        {
            if (ModelState.IsValid)
            {
                Repository.AddRequest(newCustomerRequest);
                return View("ThankYou", newCustomerRequest);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListRequests()
        {
            return View(Repository.Requests);
        }
    }
}
