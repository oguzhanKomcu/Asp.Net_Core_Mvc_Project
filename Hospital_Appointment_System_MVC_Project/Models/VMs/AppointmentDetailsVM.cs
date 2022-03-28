using Hospital_Appointment_System_MVC_Project.Models.Entities;

namespace Hospital_Appointment_System_MVC_Project.Models.VMs
{
    public class AppointmentDetailsVM
    {
        public int Id { get; set; }
        public int Patient_Id { get; set; }
        public IEnumerable<PatientListVM> PatientListVMs { get; set; }

        public int Doctor_Id { get; set; }
        public IEnumerable<DoctorListVM> DoctorListVMs { get; set; }

        public string Date { get; set; }
        public string Time { get; set; }
        public string Reason { get; set; }
        public string Prescription { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedIpAddress { get; set; }
        public string CreatedMachineName { get; set; }

        public DateTime? UpdateDate { get; set; }

        public string UpdateIpAddress { get; set; }
        public string UpdateMachineName { get; set; }

        public DateTime? DeletedDate { get; set; }

        public string DeletedIpAddress { get; set; }
        public string DeletedMachineName { get; set; }
    }
}
