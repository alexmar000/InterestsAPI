using InterestsApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace InterestsApi.Services
{
    public class WebsiteRepository : IWebsiteRepository
    {
        private readonly InterestDbContext _interestContext;
        public WebsiteRepository(InterestDbContext interestContext)
        {
            _interestContext = interestContext;
        }
        public List<Website> GetWebsitesByUserId(int userId)
        {
            var list = _interestContext.Users
                .Where(u => u.Id == userId)
                .Include(u => u.Interests)
                .ThenInclude(i => i.Websites)
                .Select(u => u.Interests)
                .FirstOrDefault();
            return list.Select(i => i.Websites).FirstOrDefault();
        }
    }
}
