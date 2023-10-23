using Microsoft.AspNetCore.Mvc;
using NøstedProsjekt.Models;
using System.Collections.Generic;

namespace NøstedProsjekt.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<ServiceOrder> serviceOrders = new List<ServiceOrder>();

        public IActionResult ServiceOrderOverview()
        {
            return View(serviceOrders);
        }
        public IActionResult Checklist()
        {
            List<ChecklistItem> checklistItems = new List<ChecklistItem>();

            for (int i = 1; i <= 50; i++)
            {
                checklistItems.Add(new ChecklistItem
                {
                    Kategorier = $"Kat{i}",
                    Sjekkpunkter = $"Sjekk{i}"
                });
            }

            return View(checklistItems);
        }

        [HttpPost]
        public IActionResult SaveChecklist(List<ChecklistItem> checklistItems)
        {
            // Save the checklist items.
            // ...

            return RedirectToAction("SomeOtherAction");
        }
    }
}