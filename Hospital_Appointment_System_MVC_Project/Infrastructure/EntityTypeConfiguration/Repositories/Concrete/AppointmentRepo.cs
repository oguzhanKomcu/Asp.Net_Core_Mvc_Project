using Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Interface;
using Hospital_Appointment_System_MVC_Project.Models.Entities;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Concrete
{
    public class AppointmentRepo : BaseRepo<Appointment>, IAppointmentRepo
    {
        public AppointmentRepo(AppDbContext appDbContext) : base(appDbContext) { }


    }
}
