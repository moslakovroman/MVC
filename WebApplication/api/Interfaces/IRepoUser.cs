using System.Collections.Generic;
using model;

namespace api.Interfaces
{
    public interface IRepoUser
    {
        List<User> GetUsers();
    }
}