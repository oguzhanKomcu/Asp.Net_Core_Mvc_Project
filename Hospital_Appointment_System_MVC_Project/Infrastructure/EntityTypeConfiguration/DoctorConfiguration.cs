using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration
{
    public class DoctorConfiguration : BaseEntityConfiguration<Doctor>
    {

        public override void Configure(EntityTypeBuilder<Doctor> builder)
        {


            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.Age).IsRequired();
            builder.Property(x => x.Specialty).IsRequired();
            builder.Property(x => x.Phone).IsRequired();



            base.Configure(builder);










        }

    }
}
