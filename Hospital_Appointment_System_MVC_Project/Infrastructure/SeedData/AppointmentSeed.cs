using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.SeedData
{
    public class AppointmentSeed : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasData(

                new Appointment { Id = 1, Patient_Id = 1, Doctor_Id = 2, Date = "10.02.2022", Time = "14:00", Reason = "Karın ağrısı", Prescription = "Ağrı kesici ilacı" },
                new Appointment { Id = 2, Patient_Id = 2, Doctor_Id = 2, Date = "10.02.2022", Time = "14:30", Reason = "Mide bulantısı", Prescription = "Mide bulantısı ilacı" },
                new Appointment { Id = 3, Patient_Id = 3, Doctor_Id = 3, Date = "12.02.2022", Time = "10:00", Reason = "Doğum için bebek kontrolü", Prescription = "Cinsiyeti belirlendi" },
                new Appointment { Id = 4, Patient_Id = 4, Doctor_Id = 1, Date = "13.02.2022", Time = "13:00", Reason = "Fazla kilo", Prescription = "Kilo vermesi için yeni bir diyet oluşturuldu." },
                new Appointment { Id = 5, Patient_Id = 5, Doctor_Id = 5, Date = "14.02.2022", Time = "15:00", Reason = "Kırık kol", Prescription = "Kol alçıya alındı" }


                );
        }
    }
}
