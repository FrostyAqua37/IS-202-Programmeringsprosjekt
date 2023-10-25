using System.ComponentModel.DataAnnotations;

namespace NøstedProsjekt.Models
{
    public class WorkDocument
    {
        public WorkDocument()
        {
        }
        public string ProductType { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        public string Order { get; set; } = string.Empty;
        public string Week { get; set; } = string.Empty;
        public string Inquiry { get; set; } = string.Empty;
        public bool CaseCompleted { get; set; }
        public string CustomerInfo { get; set; } = string.Empty;
        public DateTime? PlannedDelivery { get; set; }
        public DateTime? ProductReceivedDate { get; set; }
        public DateTime? AgreedCompletionDate { get; set; }
        public DateTime? ServiceCompletedDate { get; set; }
        public string ServiceHours { get; set; } = string.Empty;
        public bool HasOrderNumber { get; set; }
        public bool HasServiceForm { get; set; } 
    }
}