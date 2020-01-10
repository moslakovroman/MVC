using System.Collections.Generic;
using api.Interfaces;
using model;

namespace api.Repositories
{
    public class UserRepository: IRepoUser

    {
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            users.Add(new User()
            {
                Login = "lopata",
                Age = 30,
                Id = 1
            });
            users.Add(new User()
            {
                Login = "chehol",
                Age = 20,
                Id = 2
            });
            users.Add(new User()
            {
                Login = "holop",
                Age = 25,
                Id = 3
            });
            return users;
        }
    }
}