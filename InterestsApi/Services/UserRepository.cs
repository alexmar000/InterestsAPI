using InterestsApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
namespace InterestsApi.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly InterestDbContext _interestContext;
        public UserRepository(InterestDbContext interestContext)
        {
            _interestContext = interestContext;
        }

        public List<Interest> GetAllInterestsByUserId(int userId)
        {   
            var list = _interestContext.Users
              .Where(u => u.Id == userId)
              .Include(u => u.Interests)
              .ThenInclude(u => u.Websites)
              .Select(u => u.Interests)
              .ToList()
              .FirstOrDefault();
            return list;
        }

        public List<User> GetAllUsers()
        {
            return _interestContext.Users.ToList();
        }

        public User GetUserById(int id)
        {
            throw new System.NotImplementedException();
        }

        public User GetUserByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
