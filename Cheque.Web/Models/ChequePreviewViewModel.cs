using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Cheque.Web.Attribute;

namespace Cheque.Web.Models
{
    public class ChequePreviewViewModel
    {

        [Required]
        public string Name { get; set; }

        [Display(Name = "Value")]
        public string ValueInText { get; set; }

    }
}