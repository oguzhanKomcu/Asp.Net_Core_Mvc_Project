using Hospital_System_Mvc.Project.Infrastructure.EntityTypeConfiguration.Repositories.Interface;
using Hospital_System_Mvc.Project.Models.Entities;

namespace Hospital_System_Mvc.Project.Infrastructure.EntityTypeConfiguration.Repositories.Concrete
{
    public class AppointmentRepo : BaseRepo<Appointment>, IAppointmentRepo
    {
        public AppointmentRepo(AppDbContext appDbContext) : base(appDbContext) { }
        
        
    }
}
