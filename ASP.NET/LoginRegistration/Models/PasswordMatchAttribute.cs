using System.ComponentModel.DataAnnotations;
using LoginRegistration.Models;

namespace LoginRegistration.Models
{
    public class PasswordMatchAttribute: ValidationAttribute
    {
        // protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        // {
        //     if(value != User.Password)
        //     {

        //     }
        // }
    }
}