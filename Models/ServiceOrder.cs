using System.ComponentModel.DataAnnotations;

namespace NestedProsjekt.Models
{
    public class ServiceOrder   
    {
        public ServiceOrder()
        {
        }
        [Key] public int OrderId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber {  get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;    
        public string ProductType { get; set; } = string.Empty;
        public string PreferredTimePeriod { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty; 
    }
}