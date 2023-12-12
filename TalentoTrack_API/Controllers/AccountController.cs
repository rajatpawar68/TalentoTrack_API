using Microsoft.AspNetCore.Mvc;
using TalentoTrack.Common.DTOs.Account;
namespace TalentoTrack_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
       

        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Login")]
        public LoginResponse Login([FromBody]LoginRequest request)
        {
            
            return response;
        }
    }
}