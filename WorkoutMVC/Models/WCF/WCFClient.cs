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
        ServiceReference1.Service1Client proxy;
        public WCFClient()
        {
            proxy = new Service1Client();
        }

        public User createUser()
        {
            User user = null;

            proxy = new Service1Client();
            user = proxy.createUser();

            return user;
        }

        public string hello(string name)
        {
            ServiceReference1.Service1Client proxy = new Service1Client();
            return proxy.Hello(name);
        }

        public User getUser(string userName, string password)
        {
            User user = null;
            user = proxy.getUser(userName, password);
            return user;
        }

        public User saveNewUser(User u)
        {
            User user = proxy.saveNewUser(u);
            return user;
        }

        public bool userNameTaken(string userName)
        {
            bool isTaken = true;
            isTaken = proxy.isUserNameTaken(userName);
            return isTaken;
        }


    }
}