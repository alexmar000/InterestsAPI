using InterestsApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterestsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebsitesController : ControllerBase
    {
        private readonly IWebsiteRepository _websiteRepository;
        public WebsitesController(IWebsiteRepository websiteRepository)
        {
            _websiteRepository = websiteRepository;
        }

        [HttpGet("{userId}")]
        public IActionResult GetWebsitesByUserId(int userId)
            => Ok(_websiteRepository.GetWebsitesByUserId(userId));
    }
}
