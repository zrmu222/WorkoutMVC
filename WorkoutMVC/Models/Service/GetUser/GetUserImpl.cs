using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using WorkoutMVC.Models.Service;
using LibMyWorkout.Domain;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WorkoutMVC.Models.Service.GetUser
{
    public class GetUserImpl
    {

        public User getUser(string userName, string password)
        {
            User user = null;
            Task<HttpResponseMessage> responce = httpGet(userName, password);
            int code = (int) responce.Result.StatusCode;
            if (code.Equals(200))
            {
                HttpContent content = responce.Result.Content;
                string x = content.ReadAsStringAsync().Result;
                Console.WriteLine("content: " + x);
                user = JsonConvert.DeserializeObject<User>(x);

            }
            else if (code.Equals(409))
            {
                Console.WriteLine("Username Taken");
            }
            else
            {
                Console.WriteLine("Error : GetUserImpl : getUser : " + code);
            }


            return user;
        }



        private async Task<HttpResponseMessage> httpGet(string userName, string password)
        {
            HttpResponseMessage responce = null;
            try
            {
                HttpClientClass httpClient = new HttpClientClass();
                HttpClient client = httpClient.getClient();
                string uri = client.BaseAddress.ToString() + "api/User/" + userName + "/" + password + "/";
                Console.WriteLine("Uri: " + uri);
                responce = await client.GetAsync(uri).ConfigureAwait(false);


            }catch (Exception e)
            {
                Console.WriteLine("Error : GetUserImpl : httpGet : " + e.Message);
            }

            return responce;

        }






    }
}