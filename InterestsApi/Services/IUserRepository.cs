using InterestsApi.Models;
using System.Collections.Generic;

namespace InterestsApi.Services
{
    public interface IUserRepository
    {
        public List<User> GetAllUsers();
        public User GetUserById(int id);
        public User GetUserByName(string name);
        public List<Interest> GetAllInterestsByUserId(int userId);

    }
}
