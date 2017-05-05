using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibMyWorkout.Domain;

namespace WorkoutMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = (User)Session["User"];
            string loggedIn = "false";
            if(user != null)
            {
                loggedIn = "true";
            }

            ViewBag.loggedIn = loggedIn;

            return View();
        }


        public string Name()
        {
            return "Zack";
        }

    }
}