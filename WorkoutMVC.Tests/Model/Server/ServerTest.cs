using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkoutMVC.Models.Server;
using System.Collections;
using LibMyWorkout.Domain;

namespace WorkoutMVC.Tests.Model.Server
{
    [TestClass]
    public class ServerTest
    {
        ServiceManager serverManager;


        [TestInitialize]
        public void SetUp()
        {
            serverManager = new ServiceManager();
        }



        [TestMethod]
        public void CreateUser()
        {
            string userName = "zrm";
            string firstName = "Zack";
            string lastName = "Murphy";
            string password = "1234";

            Hashtable hashTable = new Hashtable();
            hashTable.Add("UserName", userName);
            hashTable.Add("FirstName", firstName);
            hashTable.Add("LastName", lastName);
            hashTable.Add("Password", password);

            Hashtable rtHashTable = serverManager.createUser(hashTable);
            User user = null;
            bool status = (bool)rtHashTable["Status"];
            string message = null;
            if (status)
            {
                user = (User)rtHashTable["User"];
                Console.WriteLine("User: " + user.ToString());
            }
            else
            {
                message = (string)rtHashTable["ErrorMessage"];
                Console.WriteLine(message);
            }


            Assert.IsTrue(user.validate());
        }


        [TestMethod]
        public void userNameTakenTest()
        {
            string userName = "zrmu222";
            string firstName = "Zack";
            string lastName = "Murphy";
            string password = "1234";

            Hashtable hashTable = new Hashtable();
            hashTable.Add("UserName", userName);
            hashTable.Add("FirstName", firstName);
            hashTable.Add("LastName", lastName);
            hashTable.Add("Password", password);

            Hashtable rtHashTable = serverManager.createUser(hashTable);
            User user = null;
            bool status = (bool)rtHashTable["Status"];
            string message = null;
            if (status)
            {
                user = (User)rtHashTable["User"];
                Console.WriteLine("User: " + user.ToString());
            }
            else
            {
                message = (string)rtHashTable["ErrorMessage"];
                Console.WriteLine(message);
            }

            Assert.IsTrue(message.Equals("UserName Taken"));
        }



        [TestMethod]
        public void GetUser()
        {
            string userName = "zrmu222";
            string password = "1234";
            Hashtable hashTable = serverManager.getUser(userName, password);
            bool status = (bool)hashTable["Status"];
            User user = null;
            if (status)
            {
                user = (User)hashTable["User"];
                Console.WriteLine(user.ToString());
            }
            else
            {
                string message = (string)hashTable["ErrorMessage"];
                Console.WriteLine(message);
            }

            Assert.IsTrue(user.validate());
        }

        [TestMethod]
        public void WrongUserName()
        {
            string userName = "z";
            string password = "1234";
            Hashtable hashTable = serverManager.getUser(userName, password);
            bool status = (bool)hashTable["Status"];
            string message = null;
            User user = null;
            if (status)
            {
                user = (User)hashTable["User"];
                Console.WriteLine(user.ToString());
            }
            else
            {
                message = (string)hashTable["ErrorMessage"];
                Console.WriteLine(message);
            }

            Assert.IsTrue(message.Equals("Wrong Username or Password"));
        }


        [TestMethod]
        public void WrongPassword()
        {
            string userName = "zrmu222";
            string password = "1";
            Hashtable hashTable = serverManager.getUser(userName, password);
            bool status = (bool)hashTable["Status"];
            string message = null;
            User user = null;
            if (status)
            {
                user = (User)hashTable["User"];
                Console.WriteLine(user.ToString());
            }
            else
            {
                message = (string)hashTable["ErrorMessage"];
                Console.WriteLine(message);
            }

            Assert.IsTrue(message.Equals("Wrong Username or Password"));
        }


    }
}
