using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System;
namespace FormSubmissionValidations.Models
{
        public class FutureDateAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                DateTime inputDateTime = Convert.ToDateTime(value);
                if(inputDateTime > DateTime.Now)
                {
                    return new ValidationResult("Date cannot be in the future!");
                }
                else if(inputDateTime <  DateTime.Now.AddYears(-150))
                {
                    return new ValidationResult("Are you really older than 150 years old?");
                }
                return ValidationResult.Success;
            }
        }
}