using System.ComponentModel.DataAnnotations;

namespace Hospital_Appointment_System_MVC_Project.Models.DTOs
{
    public class DoctorCreateDTO
    {
        [Required(ErrorMessage = "Must to type first First Name")]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Must to type first Last Name")]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Must to type first Identity No")]

        public string Specialty { get; set; }

        [Required(ErrorMessage = "Must to type first Age")]


        [RegularExpression(@"[0-9]", ErrorMessage = "Only letters ars allowed")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Must to type first Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Must to type first Phone")]

        [StringLength(11, ErrorMessage = "Maximum lenght is 11")]

        [RegularExpression(@"[0-9]", ErrorMessage = "Only letters ars allowed")]
        public string Phone { get; set; }
    }
}
