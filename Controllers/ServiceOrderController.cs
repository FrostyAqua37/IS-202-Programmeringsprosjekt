using Microsoft.AspNetCore.Mvc;
using NøstedProsjekt.Models;
using System.Collections.Generic;

namespace Nøsted.Controllers
{
    public class ServiceOrderController : Controller
    {
        public static List<ServiceOrder> serviceOrder = new List<ServiceOrder>();
        public static List<WorkDocument> workDocument = new List<WorkDocument>();
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Overview()
        {
            return View();
        }

        public IActionResult Checklist()
        {
            return View();
        }

        public IActionResult WorkDocument()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateServiceform(int OrderId, string FirstName, string LastName, string PhoneNumber, string Email, string ProductName, string ProductType, string PreferredTimePeriod, string Comment)
        {
            ServiceOrder serviceOrder = new ServiceOrder();
            serviceOrder.OrderId = OrderId;
            serviceOrder.FirstName = FirstName;
            serviceOrder.LastName = LastName;
            serviceOrder.PhoneNumber = PhoneNumber;
            serviceOrder.Email = Email;
            serviceOrder.ProductName = ProductName;
            serviceOrder.ProductType = ProductType;
            serviceOrder.PreferredTimePeriod = PreferredTimePeriod;
            serviceOrder.Comment = Comment;

            return View("Overview");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateWorkDocument(string ProductType, string Comment, string Order, string Week, string Inquiry, bool CaseCompleted, string CustomerInfo, DateTime? PlannedDelivery, DateTime? ProductReceivedDate, DateTime? AgreedCompletionDate, DateTime? ServiceCompletedDate, string ServiceHours, bool HasOrderNumber, bool HasServiceForm)
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

            return View("Create");
        }
    }
}
