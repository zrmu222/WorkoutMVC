using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibMyWorkout.Domain;
using WorkoutMVC.Models.Service.GetWorkouts;

namespace WorkoutMVC.Models.Business
{
    public class WorkoutManager
    {
        
        public IList<Exercise> getExercises(User user)
        {
            GetWorkoutImpl getWorkout = new GetWorkoutImpl();
            IList<Exercise> exerciseList = getWorkout.getExercises(user);
            return exerciseList;

        }



    }
}