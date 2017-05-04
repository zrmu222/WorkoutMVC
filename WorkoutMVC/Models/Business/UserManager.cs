using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkoutMVC.Models.Service.CreateUser;
using WorkoutMVC.Models.Service.GetUser;
using LibMyWorkout.Domain;

namespace WorkoutMVC.Models.Business
{
    public class UserManager
    {

        public User getUser(string userName, string password)
        {
            GetUserImpl getUserService = new GetUserImpl();
            User user = getUserService.getUser(userName, password);
            return user;
        }

        public User createUser(User user)
        {
            CreateUserImpl createUserService = new CreateUserImpl();
            bool status = createUserService.createUserAsync(user);
            User u = null;
            Console.WriteLine(status);
            if(status)
            {
                GetUserImpl getUserService = new GetUserImpl();
                u = getUserService.getUser(user.UserName, user.Password);
                Console.WriteLine("UserManager : User: " + u.ToString());
            }
            else
            {
                Console.WriteLine("Error creating user : UserManager : createUser");
            }


            return u;
        }





    }
}