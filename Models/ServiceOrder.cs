using System.ComponentModel.DataAnnotations;

namespace NøstedProsjekt.Models
{
    public class ServiceOrder
    {
        [Key]
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
    }
}
