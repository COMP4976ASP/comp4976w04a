using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace w04a.Models
{
    public class nameLimit : ValidationAttribute
    {
        private readonly int _max;

        //ProductName does not exceed n words
        //max is function parameter
        public nameLimit(int max) : base("{0} contains invalid character.")
        {
            _max = max;
        }

        //value is user input
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {

                int num = value.ToString().Split(' ').Count();
                if (num > _max)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;
        }
    }
}