using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibMyWorkout.Domain;
using WorkoutMVC.Models.Business;

namespace WorkoutMVC.Controllers
{
    public class WorkoutController : Controller
    {
        // GET: Workout
        public ActionResult Index()
        {

            User user = (User)Session["User"];

            if(user == null)
            {
                RedirectToAction("Index", "Login");
            }

            WorkoutManager manager = new WorkoutManager();
            IList<Exercise> exerciseList = manager.getExercises(user);
            Exercise ex1 = exerciseList[0];
            Exercise ex2 = exerciseList[1];
            Exercise ex3 = exerciseList[2];

            ViewBag.name1 = ex1.Name;
            ViewBag.weight1 = ex1.Weight;
            ViewBag.reps1 = ex1.Reps;
            ViewBag.sets1 = ex1.Sets;

            ViewBag.name2 = ex2.Name;
            ViewBag.weight2 = ex2.Weight;
            ViewBag.reps2 = ex2.Reps;
            ViewBag.sets2 = ex2.Sets;

            ViewBag.name3 = ex3.Name;
            ViewBag.weight3 = ex3.Weight;
            ViewBag.reps3 = ex3.Reps;
            ViewBag.sets3 = ex3.Sets;

            ViewBag.firstName = user.FirstName;
            ViewBag.lastName = user.LastName;
            ViewBag.weekNumber = user.CurrentWeek;
            ViewBag.dayNumber = user.CurrentDay;



            return View();
        }

        // GET: Workout/workout
        public ActionResult Workout()
        {

            return View();
        }
    }


}