using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibMyWorkout.Domain;
using WorkoutMVC.Models.Service.CreateUser;
using System.Threading.Tasks;

namespace WorkoutMVC.Tests.Model.Services
{
    [TestClass]
    public class CreateUserTest
    {
        CreateUserImpl createUser;

        [TestInitialize]
        public void setUp()
        {
            createUser = new CreateUserImpl();
        }


        [TestMethod]
        public void createUserSuccess()
        {
            Console.WriteLine("Starting CreateUser Success Test");
            User user = new User();
            user.FirstName = "John";
            user.LastName = "Smith";
            user.UserName = "JSmith6";
            user.Password = "1234";
            Task<string> location = createUser.createUserAsync(user);
            Console.WriteLine("Location: " + location.Result);
            Assert.IsTrue(location != null);
            Console.WriteLine("CreateUser Success Passed");
        }
    }
}
