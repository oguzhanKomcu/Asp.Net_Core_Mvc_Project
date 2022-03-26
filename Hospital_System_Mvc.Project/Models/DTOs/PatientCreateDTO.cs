using System.ComponentModel.DataAnnotations;

namespace Hospital_System_Mvc.Project.Models.DTOs
{
    public class PatientCreateDTO
    {

        [Required(ErrorMessage = "Must to type first First Name")]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        [RegularExpression(@"[a-zA-Z ]+$", ErrorMessage = "Only letters ars allowed")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Must to type first Last Name")]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        [RegularExpression(@"[a-zA-Z ]+$", ErrorMessage = "Only letters ars allowed")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Must to type first Identity No")]
        [MaxLength(11, ErrorMessage = "Maximum lenght is 11")]
        [MinLength(11, ErrorMessage = "Minimum lenght is 31")]

        [RegularExpression(@"[0-9]+$", ErrorMessage = "Only letters ars allowed")]
        public string Identity_No { get; set; }

        [Required(ErrorMessage = "Must to type first age")]

        [RegularExpression(@"[0-9]+$", ErrorMessage = "Only letters ars allowed")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Must to type first age")]
        public string Address { get; set; }

        [MaxLength(11, ErrorMessage = "Maximum lenght is 11")]
        [MinLength(11, ErrorMessage = "Minimum lenght is 31")]

        [RegularExpression(@"[0-9]+$", ErrorMessage = "Only letters ars allowed")]
        public string Phone { get; set; }
    }
}
