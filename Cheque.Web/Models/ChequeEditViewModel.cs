using Cheque.Web.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cheque.Web.Models
{
    public class ChequeEditViewModel
    {


        [Required]
        [MinWord(2,ErrorMessage ="The Name should have at least two words")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Value is required")]
        [Range(0.01, 999999999, ErrorMessage = "Value must be greater than 0.00")]
        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "value can't have more than 2 decimal places")]
        public double Value { get; set; }
    }
}