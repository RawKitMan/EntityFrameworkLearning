using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<User> GetByFirstName(string firstName)
        {
            return ApplicationDbContext.Users
                        .Where(u => u.FirstName == firstName)
                        .OrderByDescending(u => u.LastName);
        }

        public User GetOneByFirstName(string firstName)
        {
            return ApplicationDbContext.Users
                .SingleOrDefault(u => u.FirstName == firstName);
        }

        public bool HasAny()
        {
            return ApplicationDbContext.Users.Any();
        }

        public int CountOfFirstNameCJ()
        {
            return ApplicationDbContext.Users
                .Count(u => u.FirstName == "CJ");
        }

        public int CountMatchingFirstName(string firstName)
        {
            return ApplicationDbContext.Users
                .Count(u => u.FirstName == firstName);
        }

        public int GetMaximumUserId()
        {
            return ApplicationDbContext.Users
                .Max(u => u.UserId);
        }

        public int GetMinimumUserId()
        {
            return ApplicationDbContext.Users
                .Min(u => u.UserId);
        }

        public IEnumerable GetAllFirstNames()
        {
            return ApplicationDbContext.Users
                .Select(u => u.FirstName)
                .ToList();
        }
        public ApplicationDbContext ApplicationDbContext
        {
            get
            {
                return Context as ApplicationDbContext;
            }
        }
    }
}
