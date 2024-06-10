using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class StockController : Controller
    {

        [HttpGet("stok-ekle")]
        public IActionResult AddStock()
        {
            return View();
        }
    }
}
