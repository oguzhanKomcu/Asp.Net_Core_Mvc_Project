namespace Hospital_Appointment_System_MVC_Project.Models.VMs
{
    public class PatientDetailsVM
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identity_No { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

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
