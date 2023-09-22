using Microsoft.AspNetCore.Mvc;
using TImeSheetsSample.Domain.Services.Interfaces;
using TImeSheetsSample.Domain.ValueObjects;
using TImeSheetsSample.Models.DataTransferObjects;

namespace TImeSheetsSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController: ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService, IUserService userService)
        {
            _loginService = loginService;
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var user = await _userService.GetUser(request);

            var loginResponse = await _loginService.Authenticate(user);

            return Ok(loginResponse);
        }
        
        [HttpGet("refresh")]
        public async Task<IActionResult> Refresh()
        {
            // return new (refresh, access);
            
            var rub100 = Money.FromDecimal(100);

            return null;
        }
    }
}