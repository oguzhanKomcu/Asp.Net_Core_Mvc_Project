using Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Interface;
using Hospital_Appointment_System_MVC_Project.Models.Entities;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Concrete
{
    public class DoctorRepo : BaseRepo<Doctor>, IDoctorRepo
    {
        public DoctorRepo(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
