using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetByFirstName(string firstName);
    }
}
