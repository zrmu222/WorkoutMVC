using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using WorkoutMVC.Models.Service;
using LibMyWorkout.Domain;
using System.Threading.Tasks;

namespace WorkoutMVC.Models.Service.GetUser
{
    public class GetUserImpl
    {

        public async Task<HttpResponseMessage> getUser(string userName, string password)
        {
            Task<User> user = null;
            try
            {
                HttpClientClass httpClient = new HttpClientClass();
                HttpClient client = httpClient.getClient();
                string uri = client.BaseAddress.ToString() + "api/User/" + userName + "/" + password + "/";
                Console.WriteLine("Uri: " + uri);
                using (HttpResponseMessage responce = await client.GetAsync(uri))
                {

                }

            }catch (Exception e)
            {
                Console.WriteLineMessage)
            }

            return responce;

        }






    }
}