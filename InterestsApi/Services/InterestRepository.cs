using InterestsApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace InterestsApi.Services
{
    public class InterestRepository : IInterestRepository
    {
        private readonly InterestDbContext _interestContext;
        public InterestRepository(InterestDbContext interestContext)
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
        public Interest CreateNewInterest(Interest newInterest, int? userId = null)
        {
            if (userId != null)
            {
                var user = _interestContext.Users
                    .Include(u => u.Interests)
                    .First(u => u.Id == userId);
                user.Interests.Add(newInterest);
            }
            else 
            {
               _interestContext.Interests.Add(newInterest);
            }
            _interestContext.SaveChanges();
            return newInterest;
        }

        public Interest AddWebsiteByInterestId(Website newWebsite, int interestId)
        {
            var selInterest = _interestContext.Interests
                .Include(i => i.Websites)
                .First(i => i.Id == interestId);
            selInterest.Websites.Add(newWebsite);
            _interestContext.SaveChanges();
            return selInterest;
        }
    }
}
