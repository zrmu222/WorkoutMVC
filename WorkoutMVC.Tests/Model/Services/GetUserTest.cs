using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkoutMVC.Models.Service.GetUser;
using LibMyWorkout.Domain;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace WorkoutMVC.Tests.Model.Services
{
    [TestClass]
    public class GetUserTest
    {
        GetUserImpl getUser;



        [TestMethod]
        public void HttpGetUser()
        {
            getUser = new GetUserImpl();
            User user = getUser.getUser("Admin", "Password");
            if (user.validate())
            {
                Console.WriteLine("User: " + user.ToString());
            }
            else
            {
                Console.WriteLine("Wrong username or password");
            }
            


        }
    }
}
