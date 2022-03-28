using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Hospital_Appointment_System_MVC_Project.Models.VMs;

namespace Hospital_Appointment_System_MVC_Project.Models.DTOs
{
    public class AppointmentCreateDTO
    {
        public int Patient_Id { get; set; }
        public IEnumerable<PatientListVM> PatientListVMs { get; set; }

        public int Doctor_Id { get; set; }
        public IEnumerable<DoctorListVM> DoctorListVMs { get; set; }

        public string Date { get; set; }
        public string Time { get; set; }
        public string Reason { get; set; }
        public string Prescription { get; set; }
    }
}
