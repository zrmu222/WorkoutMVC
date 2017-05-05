using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibMyWorkout.Domain;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WorkoutMVC.Models.Service.GetWorkouts
{
    public class GetWorkoutImpl
    {


        public IList<Exercise> getExercises(User user)
        {
            IList<Exercise> exerciseList = null;
            Task<HttpResponseMessage> responce =  httpGet(user.UserId);
            int code = (int)responce.Result.StatusCode;
            if(code == 200)
            {
                HttpContent content = responce.Result.Content;
                string x = content.ReadAsStringAsync().Result;
                Console.WriteLine("content: " + x);
                exerciseList = JsonConvert.DeserializeObject<List<Exercise>>(x);
            }
            else
            {
                Console.WriteLine("Error : GetWorkoutImpl : getExercise : " + code);
            }

            return exerciseList;
        }


        private async Task<HttpResponseMessage> httpGet(int id)
        {
            HttpResponseMessage responce = null;
            try
            {
                HttpClientClass httpClient = new HttpClientClass();
                HttpClient client = httpClient.getClient();
                string uri = client.BaseAddress.ToString() + "api/Workout/" + id;
                responce = await client.GetAsync(uri).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : getWorkoutImpl : httpGet : " + e.Message);
            }

            return responce;
        }



    }
}