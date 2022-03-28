using Hospital_Appointment_System_MVC_Project.Models.DTOs;
using Hospital_Appointment_System_MVC_Project.Models.VMs;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.Service
{
    public interface IPatientService
    {
        void Create(PatientCreateDTO patientCreateDTO);
        void Update(PatientUpdateDTO patientUpdateDTO);
        void Delete(int id);
        PatientDetailsVM GetDetails(int id);
        PatientUpdateDTO Get(int id);
        IEnumerable<PatientListVM> GetAll();

    }
}
