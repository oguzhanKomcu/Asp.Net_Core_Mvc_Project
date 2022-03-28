using Hospital_Appointment_System_MVC_Project.Models.DTOs;
using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Hospital_Appointment_System_MVC_Project.Models.VMs;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.Service
{
    public interface IAppointmentService
    {
        void Create(AppointmentCreateDTO model);


        AppointmentCreateDTO GetPatientDoctor();


        List<Appointment> Gets();

        AppointmentUpdateDTO GetById(int id);


        void Delete(int id);
        AppointmentDetailsVM GetDetails(int id);


    }
}
