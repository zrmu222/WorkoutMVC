using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace WorkoutMVC.Models.Service.CreateUser
{
    public class GetUserImpl : ICreateUser 
    {
        public async HttpResponseMessage getUser(string userName, string password)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage responce = await client("", );




            return new HttpResponseMessage();
        }
    }
}