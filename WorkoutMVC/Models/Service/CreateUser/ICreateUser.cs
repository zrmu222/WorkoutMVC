using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibMyWorkout.Domain;
using System.Net.Http;

namespace WorkoutMVC.Models.Service.CreateUser
{
    public interface ICreateUser : IService
    {
        Task<string> createUserAsync(User user);


    }
}
