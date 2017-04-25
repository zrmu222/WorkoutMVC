using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibMyWorkout.Domain;
using WorkoutMVC.ServiceReference1;

namespace WorkoutMVC.Models.WCF
{
    public class WCFClient
    {


        public User createUser()
        {
            User user = null;

            ServiceReference1.Service1Client proxy = new Service1Client();
            user = proxy.createUser();

            return user;
        }





    }
}