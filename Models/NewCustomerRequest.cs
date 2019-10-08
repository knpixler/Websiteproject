using System.ComponentModel.DataAnnotations;

namespace BuckeyeLawnServices.Models
{
    public class NewCustomerRequest
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression(@"\(?\d{3}\)?[-\.]? *\d{3}[-\.]? *[-\.]?\d{4}", ErrorMessage = "Please enter a valid phone number (XXX) XXX-XXXX")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [RegularExpression(@"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$+(^[\w\s]+,\s\w{2}\s\d{5}$)|", ErrorMessage = "Please enter a valid address")]
        public string Address { get; set; }

    }
}
