using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkoutMVC.Models.Business;
using LibMyWorkout.Domain;

namespace WorkoutMVC.Tests.Model.Business
{
    [TestClass]
    public class UserManagerTest
    {




        [TestMethod]
        public void businessGetUser()
        {
            UserManager manager = new UserManager();
            User user = manager.getUser("Admin", "Password");
            Assert.IsTrue(user.validate());
            Console.WriteLine("User: " + user.ToString());

        }

        [TestMethod]
        public void businessCreaateUser()
        {
            User user = new User();
            user.FirstName = "John";
            user.LastName = "Smith";
            user.UserName = "JSmith11";
            user.Password = "1234";
            UserManager manager = new UserManager();
            User u = manager.createUser(user);
            //Assert.IsTrue(user.validate());
            Console.WriteLine("User: " + u.ToString());


        }
    }
}
