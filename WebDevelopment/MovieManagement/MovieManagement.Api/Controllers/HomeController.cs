using Microsoft.AspNetCore.Mvc;

namespace MovieManagement.Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
