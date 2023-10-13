using Microsoft.AspNetCore.Mvc;

namespace Nøsted.Controllers
{
    public class WorkScheduleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
