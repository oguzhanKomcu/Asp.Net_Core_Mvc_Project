namespace Hospital_Appointment_System_MVC_Project.Models.Entities
{
    public class Appointment :BaseEntity
    {
        public int Patient_Id { get; set; }
        public Patient Patient { get; set; }
        public int Doctor_Id { get; set; }
        public Doctor Doctor { get; set; }

        public string Date { get; set; }
        public string Time { get; set; }
        public string Reason { get; set; }
        public string Prescription { get; set; }
    }
}
