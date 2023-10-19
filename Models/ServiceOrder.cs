namespace NøstedProsjekt.Models
{
    public class ServiceOrder
    {
        public int Id { get; set; }

        // Customer Information
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;

        // Product Details
        public string ProductName { get; set; } = string.Empty;
        public string ProductType { get; set; } = string.Empty;

        // Service Details
        public string PreferredTimePeriod { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

        //Abreidsdokument
        public string Week { get; set; } = string.Empty; //1

        public string Inquiry {  get; set; } = string.Empty;
       
        public bool CaseCompleted { get; set; }

        public string CustomerInfo { get; set; } = string.Empty;

        public string PlannedDelivery { get; set; } = string.Empty;
        
        public DateTime? ProductReceivedDate { get; set; }
        public DateTime? AgreedCompletionDate { get; set; }
        public DateTime? ServiceCompletedDate { get; set; }
        public string ServiceHours { get; set; } = string.Empty;
        public bool HasOrderNumber { get; set; } 
        public bool HasServiceForm { get; set; }
    }
}
