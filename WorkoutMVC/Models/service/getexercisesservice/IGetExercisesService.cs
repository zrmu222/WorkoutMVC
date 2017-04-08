using System;
using System.Collections.Generic;

using myworkout.model.domain;

namespace myworkout.model.service.getExercisesService
{
	public interface IGetExercisesService : IService
	{

		IList<Exercise> getExercises(User user);

	}
}
