using System.ComponentModel.DataAnnotations;

namespace Nøsted.Models
{
    public class ServiceForm
    {
        public ServiceForm()
        {
            
        }

        [Key]
        public int OrderNr { get; set; }

        public int ServiceNr { get; set; }

        public string Modell { get; set; }

        public string Kommentar { get; set; }

        public string Email { get; set; }

    }
}
