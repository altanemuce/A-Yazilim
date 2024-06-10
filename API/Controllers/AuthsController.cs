using Business.Abstract;
using Entities.DTOs.Auth;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthsController(IAuthService authService)
        {
            _authService = authService;
        }


        [HttpPost("register")]

        public async Task<IActionResult> Register(RegisterUser registerUser)
        {
            var result = await _authService.RegisterUser(registerUser);
            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUser loginUser)
        {
            var result = await _authService.LoginUser(loginUser);
            return Ok(result);
        }
    }
}
