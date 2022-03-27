using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration
{
    public class PatientConfiguration : BaseEntityConfiguration<Patient>
    {

        public override void Configure(EntityTypeBuilder<Patient> builder)
        {


            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.Age).IsRequired();
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.Phone).IsRequired().IsUnicode().HasMaxLength(11);
            builder.Property(x => x.Identity_No).IsRequired().IsUnicode().HasMaxLength(11);


            base.Configure(builder);










        }

    }
}
