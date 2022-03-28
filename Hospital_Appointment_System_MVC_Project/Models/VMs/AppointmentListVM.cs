namespace Hospital_Appointment_System_MVC_Project.Models.VMs
{
    public class AppointmentListVM
    {
        public int Id { get; set; }
        public string Patient_FirstName { get; set; }
        public string Patient_LastName { get; set; }
        public string Patient_FullName => Patient_FirstName+" "+Patient_LastName;

        public string Doctor_FirstName { get; set; }
        public string Doctor_LastName { get; set; }
        public string Doctor_FullName => Doctor_FirstName+" "+Doctor_LastName;

        public string Date { get; set; }
        public string Time { get; set; }
        public string Reason { get; set; }
        public string Prescription { get; set; }
        
    }
}
