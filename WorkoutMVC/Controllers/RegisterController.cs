using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkoutMVC.Models.Business;
using LibMyWorkout.Domain;

namespace WorkoutMVC.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult createUser(string firstName, string lastName, string userName, string password)
        {
            User u = new User();
            u.FirstName = firstName;
            u.LastName = lastName;
            u.UserName = userName;
            u.Password = password;
            UserManager manager = new UserManager();
            User user = null;
            try
            {
                user = manager.createUser(u);
                if(user != null)
                {
                    Session["User"] = user;

                }
                else
                {
                    string error = "Username Taken";
                    RedirectToAction("Error", "Register", error);
                }


            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return RedirectToAction("Index", "User");
        }

        public ActionResult Error(string error)
        {
            TempData["Error"] = error;
            return View();
        }


    }
}