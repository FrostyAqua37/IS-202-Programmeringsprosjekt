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

        [HttpPost]
        public IActionResult CreateWorkDocument(string ProductType, string Comment, string Order, string Week, string Inquiry, bool CaseCompleted, string CustomerInfo, string PlannedDelivery, DateTime? ProductReceivedDate, DateTime? AgreedCompletionDate, DateTime? ServiceCompletedDate, string ServiceHours, bool HasOrderNumber, bool HasServiceForm)
        {
            WorkDocument workDocument = new WorkDocument();
            workDocument.ProductType = ProductType;
            workDocument.Comment = Comment;
            workDocument.Order = Order;
            workDocument.Week = Week;
            workDocument.Inquiry = Inquiry;
            workDocument.CaseCompleted = CaseCompleted;
            workDocument.CustomerInfo = CustomerInfo;
            workDocument.PlannedDelivery = PlannedDelivery;
            workDocument.ProductReceivedDate = ProductReceivedDate;
            workDocument.AgreedCompletionDate = AgreedCompletionDate;
            workDocument.ServiceCompletedDate = ServiceCompletedDate;
            workDocument.ServiceHours = ServiceHours;
            workDocument.HasOrderNumber = HasOrderNumber;
            workDocument.HasServiceForm = HasServiceForm;

            return View();
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
