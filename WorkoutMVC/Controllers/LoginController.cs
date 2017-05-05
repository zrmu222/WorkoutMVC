using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibMyWorkout.Domain;
using WorkoutMVC.Models.Business;
using System.Threading.Tasks;

namespace WorkoutMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult getUser(string userName, string password)
        { 
                User user = GetUserHttp(userName, password);
                if (user.validate())
                {
                    Session["User"] = user;
                }

            
            return RedirectToAction("Index", "User");
        }



        private User GetUserHttp(string userName, string password)
        {
            UserManager manager = new UserManager();
            User user = null;
            try
            {
                user = manager.getUser(userName, password);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return user;
        }



    }
}