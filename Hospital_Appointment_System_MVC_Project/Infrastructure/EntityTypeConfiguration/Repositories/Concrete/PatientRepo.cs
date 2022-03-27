using Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Interface;
using Hospital_Appointment_System_MVC_Project.Models.Entities;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Concrete
{
    public class PatientRepo : BaseRepo<Patient>, IPatientRepo
    {
        public PatientRepo(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
