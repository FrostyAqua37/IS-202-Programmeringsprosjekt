using Microsoft.AspNetCore.Mvc;
using NøstedProsjekt.Models; // Add this 'using' directive for WorkDocument
using System.Collections.Generic;

namespace NøstedProsjekt.Controllers
{
    public class AdministrativController : Controller
    {
        // Use WorkDocument as the model type
        private static List<WorkDocument> workDocuments = new List<WorkDocument>();

        // Other actions...

        public IActionResult ServiceOrderOverview()
        {
            // Retrieve your work documents here
            List<WorkDocument> workDocuments = GetWorkDocuments(); // Implement this method
            return View(workDocuments);
        }

        [HttpPost]
        public IActionResult CreateServiceOrder(WorkDocument workDocument)
        {
            // Assign a new ID to the work document
            workDocument.OrderId = workDocuments.Count + 1;

            // Add the work document to the list
            workDocuments.Add(workDocument);

            // Redirect to the makeserviceorder view
            return RedirectToAction("makeserviceorder", new { orderId = workDocument.OrderId });
        }

        private List<WorkDocument> GetWorkDocuments()
        {
            // You can return the list of work documents from your private field
            return workDocuments;
        }

    }
}