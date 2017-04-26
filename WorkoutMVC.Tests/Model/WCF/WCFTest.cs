using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkoutMVC.Models.WCF;
using LibMyWorkout.Domain;

namespace WorkoutMVC.Tests.Model.WCF
{
    [TestClass]
    public class WCFTest
    {
        WCFClient proxy;

        [TestInitialize]
        public void SetUp()
        {
            proxy = new WCFClient();
        }



        [TestMethod]
        public void name()
        {
            string hello = proxy.hello("Zack");
            Console.WriteLine(hello);
        }

        [TestMethod]
        public void saveNewUserTest()
        {
            User user = proxy.createUser();
            User u = null;
            string userName = "Zack";
            user.UserName = userName;
            user.FirstName = "Admin";
            user.LastName = "Admin";
            user.Password = "Password";
            bool isTaken = proxy.userNameTaken(userName);
            if (!isTaken)
            {
                u = proxy.saveNewUser(user);
                if (u != null)
                {
                    Console.WriteLine(u.ToString());
                }
            }
            else
            {
                Console.WriteLine("Username taken");
            }
            Assert.IsTrue(u.validate());
        }

        [TestMethod]
        public void getUser()
        {
            string userName = "Admin";
            string password = "Password";
            User user = proxy.getUser(userName, password);

            if (user != null)
            {
                Console.WriteLine(user.ToString());
                foreach(Week wk in user.Weeks)
                {
                    foreach(Day day in wk.Days)
                    {
                        Console.WriteLine(day.ToString());
                    }
                }
            }

            Assert.IsTrue(user.validate());
        }

        [TestMethod]
        public void checkUserNameTest()
        {
            string userName = "Admin";
            bool isTaken = proxy.userNameTaken(userName);
            Console.WriteLine("isTaken: " + isTaken);
            Assert.IsTrue(isTaken);
            
        }

    }
}
