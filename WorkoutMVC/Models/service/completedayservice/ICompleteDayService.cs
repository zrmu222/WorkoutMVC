using System;
using System.Collections;

using myworkout.model.domain;

namespace myworkout.model.service.completeDayService
{
	public interface ICompleteDayService : IService
	{
		User completeDay(User user, Hashtable hashTable);
	}
}
