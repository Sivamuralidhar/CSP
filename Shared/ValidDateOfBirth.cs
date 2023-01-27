using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CSP.Shared
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class ValidDateOfBirthAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object value, ValidationContext validationContext)
        {

            if (value == null)
            {
                return new ValidationResult("Select Date Of Birth");
            }
            else
            {
                DateTime enteredDate = DateTime.Parse(value?.ToString());
                DateTime today = DateTime.Today;
                // Calculate the age.
                int age = today.Year - enteredDate.Year;
                if (enteredDate > today)
                {
                    return new ValidationResult("Date of birth cannot be greater than current date.");
                }
                else if (age < 18)
                {
                    return new ValidationResult("Age must be minimum 18+ years.");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }

        }
    }
}