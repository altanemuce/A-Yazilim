using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class UserController : Controller
    {

        [HttpGet("/kullanici-ekle")]
        public IActionResult AddUser()
        {
            return View();
        }
    }
}
