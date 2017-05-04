using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkoutMVC.Models.Service;
using System.Net.Http;

namespace WorkoutMVC.Tests.Model.Services
{
    [TestClass]
    public class HttpClientTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            HttpClientClass clientClass = new HttpClientClass();
            HttpClient client = clientClass.getClient();
            Assert.IsNotNull(client);


        }
    }
}
