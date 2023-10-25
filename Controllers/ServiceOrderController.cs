using Microsoft.AspNetCore.Mvc;
using NøstedProsjekt.Models;
using System.Collections.Generic;
using System.Web;

namespace Nøsted.Controllers
{
    [AutoValidateAntiforgeryToken]
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
            serviceOrder.FirstName = HttpUtility.HtmlEncode(FirstName);
            serviceOrder.LastName = HttpUtility.HtmlEncode(LastName); ;
            serviceOrder.PhoneNumber = HttpUtility.HtmlEncode(PhoneNumber); 
            serviceOrder.Email = HttpUtility.HtmlEncode(Email);
            serviceOrder.ProductName = HttpUtility.HtmlEncode(ProductName);
            serviceOrder.ProductType = HttpUtility.HtmlEncode(ProductType);
            serviceOrder.PreferredTimePeriod = HttpUtility.HtmlEncode(PreferredTimePeriod);
            serviceOrder.Comment = HttpUtility.HtmlEncode(Comment);

            return View("Overview");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateWorkDocument(string ProductType, string Comment, string Order, string Week, string Inquiry, bool CaseCompleted, string CustomerInfo, DateTime? PlannedDelivery, DateTime? ProductReceivedDate, DateTime? AgreedCompletionDate, DateTime? ServiceCompletedDate, string ServiceHours, bool HasOrderNumber, bool HasServiceForm)
        {
            WorkDocument workDocument = new WorkDocument();
            workDocument.ProductType = HttpUtility.HtmlEncode(ProductType); 
            workDocument.Comment = HttpUtility.HtmlEncode(Comment);
            workDocument.Order = HttpUtility.HtmlEncode(Order);
            workDocument.Week = HttpUtility.HtmlEncode(Week);
            workDocument.Inquiry = HttpUtility.HtmlEncode(Inquiry);
            workDocument.CaseCompleted = CaseCompleted;
            workDocument.CustomerInfo = HttpUtility.HtmlEncode(CustomerInfo);
            workDocument.PlannedDelivery = PlannedDelivery;
            workDocument.ProductReceivedDate = ProductReceivedDate;
            workDocument.AgreedCompletionDate = AgreedCompletionDate;
            workDocument.ServiceCompletedDate = ServiceCompletedDate;
            workDocument.ServiceHours = HttpUtility.HtmlEncode(ServiceHours);
            workDocument.HasOrderNumber = HasOrderNumber;
            workDocument.HasServiceForm = HasServiceForm;

            return View("Create");
        }
    }
}
