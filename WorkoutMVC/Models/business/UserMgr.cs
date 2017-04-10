using System;
using System.Collections.Generic;
using System.Collections;

using myworkout.model.domain;
using myworkout.model.service.newUserSetupService;
using myworkout.model.service.databaseService;
using myworkout.model.service.exceptions.UserFileException;


namespace myworkout.model.business
{
	public class UserMgr : Manager
	{

		public User createUser()
		{
			INewUserSetUpService newUserService = (INewUserSetUpService)GetService(typeof(INewUserSetUpService).Name);
			User user = newUserService.newUserSetUp();


			return user;
		}


		public User getUser(string userName, string password)
		{
			User user = null;
			try
			{
				IDatabaseService dataBaseService = (IDatabaseService)GetService(typeof(IDatabaseService).Name);
				user = dataBaseService.getUser(userName, password);

			}
			catch (UserFileException)
			{
			}

			return user;
		}



		public User saveNewUser(User u)
		{
			User user = null;
			try
			{
				IDatabaseService dataBaseService = (IDatabaseService)GetService(typeof(IDatabaseService).Name);
				user = dataBaseService.saveNewUser(u);
			}
			catch (UserFileException)
			{
			}
			return user;
		}

        public User updateUser(User u)
        {
            User user = null;
            try
            {
                IDatabaseService dataBaseService = (IDatabaseService)GetService(typeof(IDatabaseService).Name);
                user = dataBaseService.updateUser(u);
            }
            catch (UserFileException) { }

            return user;
        }

	}
}
