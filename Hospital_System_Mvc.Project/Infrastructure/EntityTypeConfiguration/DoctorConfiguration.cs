using Hospital_System_Mvc.Project.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital_System_Mvc.Project.Infrastructure.EntityTypeConfiguration
{
    public class DoctorConfiguration :BaseEntityConfiguration<Doctor>
    {

        public override void Configure(EntityTypeBuilder<Doctor> builder)
        {


            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.Age).IsRequired();
            builder.Property(x => x.Specialty).IsRequired();
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x => x.Deparment).IsRequired();



            base.Configure(builder);










        }

    }
}
