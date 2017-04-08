using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkoutMVC.Controllers
{
    public class WorkoutController : Controller
    {
        // GET: Workout
        public ActionResult Index()
        {
            return View();
        }

        // GET: Workout/workout
        public ActionResult Workout()
        {

            return View();
        }
    }


}