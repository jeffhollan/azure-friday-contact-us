using System.ComponentModel.DataAnnotations;

namespace azure_friday.Models
{
    public class ContactForm {
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Message { get; set; }
    }
}