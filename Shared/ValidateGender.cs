using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Shared
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class ValidateGender : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object value, ValidationContext validationContext)
        {

            if (value is "undefined" || value is null)
            {
                return new ValidationResult("Please select Gender");
            }
            return ValidationResult.Success;
        }
    }

    public class ValidateLanguage : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object value, ValidationContext validationContext)
        {

            if (value is "--Select--" || value is null)
            {
                return new ValidationResult("Please select Language");
            }
            return ValidationResult.Success;
        }
    }
}
