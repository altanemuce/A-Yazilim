using Business.Abstract;
using Entities.DTOs.Stock;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IStockService _stockService;
        public StocksController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpPost("stok-ekle")]
        public async Task<IActionResult> Add(AddStock addStock)
        {
            var result = await _stockService.AddStock(addStock);
            return Ok(result);
        }

        [HttpGet("stok-listesi")]
        public IActionResult GetAll()
        {
            var result = _stockService.GetAll(false);
            return Ok(result);
        }

        [HttpPost("stok-sil/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _stockService.Remove(id);
            return Ok();
        }

    }
}
