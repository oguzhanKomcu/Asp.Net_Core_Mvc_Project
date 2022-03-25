﻿namespace Hospital_System_Mvc.Project.Models.Entities
{
    public class Patient : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identity_No { get; set; } 
        public string Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public List<Appointment> Appointments { get; set; }



    }
}
