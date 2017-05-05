using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using WorkoutMVC.Models.Service;
using LibMyWorkout.Domain;
using System.Threading.Tasks;


namespace WorkoutMVC.Models.Service.CreateUser
{
    public class CreateUserImpl : ICreateUser 
    {
        public bool createUserAsync(User user)
        {
            bool passed = false;
            Task<HttpResponseMessage> responce = httpCall(user);
            bool status = responce.Result.IsSuccessStatusCode;
            if (status)
            {
                passed = true;
                Console.WriteLine("User Created");
            }
            else
            {
                Console.WriteLine("Error creating user : " + responce.Result.StatusCode);
            }


            return passed;
        }



        private async Task<HttpResponseMessage> httpCall(User user)
        {
            string location = null;
            HttpResponseMessage responce = null;
            try
            {
                HttpClientClass httpClientClass = new HttpClientClass();
                HttpClient client = httpClientClass.getClient();
                responce = await client.PostAsJsonAsync("api/User", user).ConfigureAwait(false);

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return responce;
        }

    }
}