using Microsoft.AspNetCore.Mvc;
using NøstedProsjekt.Models;
using System.Collections.Generic;

namespace NøstedProsjekt.Controllers
{
    public class CustomerController : Controller
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
        public IActionResult CreateServiceOrder(ServiceOrder serviceOrder, string FirstName, string LastName, string PhoneNumber, string EmailAddress, string ProductName, string ProductType, string PreferredTimePeriod, string comment)
        {
            serviceOrder.Id = serviceOrders.Count + 1;
            serviceOrders.Add(serviceOrder);

            ServiceOrder serviceorder1 = new ServiceOrder();
            serviceorder1.FirstName = FirstName;
            serviceorder1.LastName = LastName;
            serviceorder1.PhoneNumber = PhoneNumber;
            serviceorder1.EmailAddress = EmailAddress;
            serviceorder1.ProductName = ProductName;
            serviceorder1.ProductType = ProductType;
            serviceorder1.PreferredTimePeriod = PreferredTimePeriod;
            serviceorder1.Comment = comment;

            return View(serviceorder1);
        }

        public IActionResult RegisterOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterOrder(ServiceOrder serviceOrder)
        {
            serviceOrder.Id = serviceOrders.Count + 1;
            serviceOrders.Add(serviceOrder);
            return RedirectToAction("Index", "Customer");
        }
    }
}
