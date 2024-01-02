using Microsoft.AspNetCore.Mvc;

namespace AttendEasy.Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
