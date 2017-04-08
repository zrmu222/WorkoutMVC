using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myworkout.model.domain;
using myworkout.model.service.databaseService;
using myworkout.model.service.newUserSetupService;
using System.Configuration;
using System.Web.Configuration;

namespace WorkoutMVC.Tests.Model.Service
{
    [TestClass]
    public class SQLServiceTest
    {

        NewUserSvcImpl newUserImpl;
        SqlSvcImpl sqlService;
        User user;

        [TestInitialize]
        public void setUp()
        {
            newUserImpl = new NewUserSvcImpl();
            sqlService = new SqlSvcImpl();
            user = newUserImpl.newUserSetUp();
            string name = ConfigurationManager.AppSettings["Name"];
           Console.WriteLine("Name: " + name);
            string connectionString = WebConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Console.WriteLine("ConnectionString in Test: " + connectionString);
        }

        [TestMethod]
        public void SaveUser()
        {
            user.UserName = "Zrmu8372";
            user.FirstName = "Zack";
            user.LastName = "Murphy";
            user.Password = "1234";
            user = sqlService.saveNewUser(user);

            Console.WriteLine("UserId: " + user.UserId);

            Console.WriteLine(user.ToString());
        }

        [TestMethod]
        public void GetUser()
        {
            User user1 = sqlService.getUser("Zrmu", "1234");
            Console.WriteLine(user1.ToString());      
        }


        [TestMethod]
        public void updateUser()
        {
            User user1 = sqlService.getUser("Zrmu", "1234");

            Console.WriteLine("User1 to String: " + user1.ToString());

            user1.FirstName = "Zack";
            user1.CurrentDay = 3;

            User u = sqlService.updateUser(user1);

            Console.WriteLine(u.ToString());
        }


    }
}
