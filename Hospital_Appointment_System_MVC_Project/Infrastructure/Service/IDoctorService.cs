using Hospital_Appointment_System_MVC_Project.Models.DTOs;
using Hospital_Appointment_System_MVC_Project.Models.VMs;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.Service
{
    public interface IDoctorService
    {
        void Create(DoctorCreateDTO doctorCreateDTO);
        void Update(DoctorUpdateDTO doctorUpdateDTO);
        void Delete(int id);
        DoctorDetailsVM GetDetails(int id);
        DoctorUpdateDTO Get(int id);
        IEnumerable<DoctorListVM> GetAll();
    }
}
