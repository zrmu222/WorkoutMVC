using System;
using myworkout.model.domain;

namespace myworkout.model.service.databaseService
{
    public interface IDatabaseService : IService
    {
        User getUser(string userName, string password);

        User saveNewUser(User user);

        User updateUser(User user);

    }


}
