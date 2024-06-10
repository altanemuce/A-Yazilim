using Business.Abstract;
using Entities.DTOs.Current;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CurrentsController : ControllerBase
	{
		private readonly ICurrentService _currentService;
		public CurrentsController(ICurrentService currentService)
		{
			_currentService = currentService;
		}


		[HttpPost("cari-ekle")]
		public async Task<IActionResult> Add(AddCurrent addCurrent)
		{
			var result = await _currentService.AddCurrent(addCurrent);
			return Ok(result);
		}

		[HttpGet("cari-listesi")]
		public IActionResult GetAll()
		{
			var result = _currentService.GetAll(false);
			return Ok(result);
		}
	}
}
