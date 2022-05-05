using InterestsApi.Models;
using InterestsApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterestsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestsController : ControllerBase
    {
        private readonly IInterestRepository _interestRepository;
        public InterestsController(IInterestRepository interestRepository)
        {
            _interestRepository = interestRepository;
        }

        [HttpGet("{userId}")]
        public IActionResult GetAllInterestsByUserId(int userId)
            => Ok(_interestRepository.GetAllInterestsByUserId(userId));

        [HttpPost("{userId?}")]
        public IActionResult CreateNewInterest(Interest newInterest, int? userId)
        {
            _interestRepository.CreateNewInterest(newInterest, userId);
            return Created(HttpContext.Request.Scheme + "://"
                + HttpContext.Request.Host
                + HttpContext.Request.Path + "/", newInterest);
        }

        [HttpPost("updatewebsite/{interestId}")]
        public IActionResult AddUrlByInterestId(Website newWebsite, int interestId)
            => Ok(_interestRepository.AddWebsiteByInterestId(newWebsite, interestId));

    }
}
