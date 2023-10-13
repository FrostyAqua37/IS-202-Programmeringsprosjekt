using Microsoft.AspNetCore.Mvc;

namespace Nøsted.Controllers
{
    public class NotificationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
