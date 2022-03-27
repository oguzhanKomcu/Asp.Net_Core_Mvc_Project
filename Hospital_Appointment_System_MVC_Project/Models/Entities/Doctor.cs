namespace Hospital_Appointment_System_MVC_Project.Models.Entities
{
    public class Doctor :BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }



        public string Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public List<Appointment> Appointments { get; set; }
    }
}
