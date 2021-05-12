using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetByFirstName(string firstName);
        User GetOneByFirstName(string firstname);
        bool HasAny();
        int CountOfFirstNameCJ();
        int CountMatchingFirstName(string firstName);
        int GetMaximumUserId();
        int GetMinimumUserId();
        IEnumerable GetAllFirstNames();

    }
}
