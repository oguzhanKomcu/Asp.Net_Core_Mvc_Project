using Hospital_System_Mvc.Project.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital_System_Mvc.Project.Infrastructure.EntityTypeConfiguration
{
    public class AppointmentConfiguration :BaseEntityConfiguration<Appointment>
    {
        
        public override void Configure (EntityTypeBuilder<Appointment> builder)
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






            base.Configure (builder);
        }



    }
}
