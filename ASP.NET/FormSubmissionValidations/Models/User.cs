using System.ComponentModel.DataAnnotations;

namespace FormSubmissionValidations.Models
{
    public class User
    {
        [Required]
        [MinLength(2)]
        [Display(Name="First Name:")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        [Display(Name="Last Name:")]

        public string LastName { get; set; }
        [Required]
        [Range(0,199)]
        [Display(Name="Age:")]

        public int Age { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name="Email Address:")]

        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Display(Name="Password:")]

        public string Password { get; set; }
    }
}