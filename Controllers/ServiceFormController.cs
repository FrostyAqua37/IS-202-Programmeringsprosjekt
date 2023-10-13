using Microsoft.AspNetCore.Mvc;

namespace Nøsted.Controllers
{
    public class ServiceFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
