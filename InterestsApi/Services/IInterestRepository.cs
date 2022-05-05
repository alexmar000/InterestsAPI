using InterestsApi.Models;
using System.Collections.Generic;

namespace InterestsApi.Services
{
    public interface IInterestRepository
    {
        public List<Interest> GetAllInterestsByUserId(int userId);
        public Interest CreateNewInterest(Interest newInterest, int? userId = null);
        public Interest AddWebsiteByInterestId(Website newWebsite, int interestId);

    }
}
