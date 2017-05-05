using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibMyWorkout.Domain;

namespace WorkoutMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {

            User user = (User)Session["User"];
            return View(user);
        }
    }
}