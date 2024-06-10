using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class CurrentController : Controller
    {

        [HttpGet("cari-kart-ekle")]
        public IActionResult CurrentAdd()
        {
            return View();
        }
    }
}
