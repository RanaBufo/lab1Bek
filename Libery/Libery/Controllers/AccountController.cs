using Microsoft.AspNetCore.Mvc;

namespace Libery.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
