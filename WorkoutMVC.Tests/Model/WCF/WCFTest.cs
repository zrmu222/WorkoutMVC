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
        public void wcfGetUser()
        {

            Console.WriteLine("Starting getUserTest");
            User user = proxy.createUser();
            Console.WriteLine("User: " + user.ToString());
            Assert.IsTrue(user.validate());
        }
    }
}
