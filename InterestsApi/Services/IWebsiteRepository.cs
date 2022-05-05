using InterestsApi.Models;
using System.Collections.Generic;

namespace InterestsApi.Services
{
    public interface IWebsiteRepository
    {
        public List<Website> GetWebsitesByUserId(int userId);
    }
}
