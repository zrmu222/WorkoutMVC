using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myworkout.model.domain;
using myworkout.model.service.databaseService;
using myworkout.model.service.newUserSetupService;
using System.Configuration;
using System.Web.Configuration;
using myworkout.model.business;

namespace WorkoutMVC.Tests.Model.Service
{
    [TestClass]
    public class SQLServiceTest
    {      
        User user;
        UserMgr userManager;       


        [TestInitialize]
        public void setUp()
        { 
            userManager = new UserMgr();
            user = userManager.createUser();

        }

        [TestMethod]
        public void SaveUser()
        {
            user.UserName = "Zrmu222";
            user.FirstName = "Zack";
            user.LastName = "Murphy";
            user.Password = "1234";
            user = userManager.saveNewUser(user);

            Console.WriteLine("UserId: " + user.UserId);

            Console.WriteLine(user.ToString());
        }

        [TestMethod]
        public void GetUser()
        {
            User user1 = userManager.getUser("Zrmu", "1234");
            Console.WriteLine(user1.ToString());      
        }


        [TestMethod]
        public void updateUser()
        {
            User user1 = userManager.getUser("Zrmu", "1234");

            Console.WriteLine("User1 to String: " + user1.ToString());

            user1.FirstName = "Zack";
            user1.CurrentDay = 3;

            User u = userManager.updateUser(user1);

            Console.WriteLine(u.ToString());
        }


    }
}
