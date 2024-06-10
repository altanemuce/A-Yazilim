using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly IUserService _userService;
		public UsersController(IUserService userService)
		{
			_userService = userService;
		}


		[HttpGet("list-user")]
		public IActionResult GetAll()
		{
			var result = _userService.GetAllUser(false);
			return Ok(result);
		}
	}
}
