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
        public async Task<string> createUserAsync(User user)
        {
            string location = await httpCall(user);


            return location;
        }



        private async Task<string> httpCall(User user)
        {
            string location = null;
            try
            {
                HttpClientClass httpClientClass = new HttpClientClass();
                HttpClient client = httpClientClass.getClient();              
                using (HttpResponseMessage responce = await client.PostAsJsonAsync("api/User", user))
                {
                    int code = (int)responce.StatusCode;
                    Console.WriteLine("Code: " + code);
                    if (code.Equals(201))
                    {
                        location = responce.Headers.Location.ToString();
                        Console.WriteLine("Location: " + location);
                    }
                    else
                    {
                        Console.WriteLine("Username is taken");
                    }

                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return location;
        }

    }
}