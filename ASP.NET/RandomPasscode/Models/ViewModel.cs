using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace RandomPasscode.Models
{
    public class ViewModel
    {
        public string RandomAlphaNumeric { get; set; }
        public int? counter { get; set; }
    }
}