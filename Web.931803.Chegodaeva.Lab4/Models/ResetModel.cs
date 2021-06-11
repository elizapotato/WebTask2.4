using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web._931803.Chegodaeva.Lab4.Models
{
    public class ResetModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Message { get; set; }

        public string Code { get; set; }
    }
}
