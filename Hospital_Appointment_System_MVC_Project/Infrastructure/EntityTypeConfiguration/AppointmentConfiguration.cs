using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration
{
    public class AppointmentConfiguration : BaseEntityConfiguration<Appointment>
    {

        public override void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasOne(x => x.Patient)
                .WithMany(x => x.Appointments)
                .HasForeignKey(x => x.Patient_Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Doctor)
                .WithMany(x => x.Appointments)
                .HasForeignKey(x => x.Doctor_Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.Time).IsRequired();
            builder.Property(x => x.Reason).IsRequired();
            builder.Property(x => x.Prescription).IsRequired(false);






            base.Configure(builder);
        }



    }
}
