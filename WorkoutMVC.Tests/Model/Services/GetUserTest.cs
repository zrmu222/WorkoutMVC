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
        public void TestMethod1()
        {
            getUser = new GetUserImpl();

            Task<HttpResponseMessage> responce = getUser.getUser("Admin", "Password");
            HttpContent content = responce.Result.Content;
            string x = content.ReadAsStringAsync().Result;
            bool status = responce.Result.IsSuccessStatusCode;
            Console.WriteLine("Status Code: " + status);
            User user = JsonConvert.DeserializeObject<User>(x);
            Console.WriteLine("User: " + user.ToString());
            //Console.WriteLine("User: " + x);
            Console.WriteLine("Headers: " + content.Headers.ToString());

        }
    }
}
