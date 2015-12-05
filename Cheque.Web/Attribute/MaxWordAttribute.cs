using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cheque.Web.Attribute
{
    public class MinWordAttribute: ValidationAttribute
    {
        private readonly int _minWords;
        public MinWordAttribute(int minWords): base("{0} should have more words.")
        {

            _minWords = minWords;
        }
        protected  override ValidationResult IsValid(object value,ValidationContext validationContext )
        {
            if(value!= null)
            {
                var result = value.ToString();
                if ( _minWords > result.Split(' ').Length )
                {
                    var error = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(error);

                }

            }
            return ValidationResult.Success;
        }
    }
}