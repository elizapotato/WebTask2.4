using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web._931803.Chegodaeva.Lab4.Models
{
    public class SignUpModel
    {
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Day { get; set; }

        public string Month { get; set; }

        public string Year { get; set; }

        public string Gender { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirm password don't match!")]
        public string Confirm { get; set; }
    }
}