using Microsoft.AspNetCore.Mvc;
using NøstedProsjekt.Models;
using System.Collections.Generic;

namespace NøstedProsjekt.Controllers
{
    public class AdministrativController : Controller
    {
        private static List<ServiceOrder> serviceOrders = new List<ServiceOrder>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateServiceOrder()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateServiceOrder(ServiceOrder serviceOrder)
        {
            serviceOrder.Id = MekanikerController.serviceOrders.Count + 1;
            MekanikerController.serviceOrders.Add(serviceOrder);
            return RedirectToAction("Index", "Customer");
        }
    }
}
