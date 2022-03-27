using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.SeedData
{
    public class DoctorSeed : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasData(

                new Doctor { Id = 1, FirstName = "Bülent", LastName = "GÜNEŞ", Specialty = "Nutritionist", Age = "41", Address = "Galata Mah.Beyoğlu/İstanbul", Phone = "05417415252" },
                new Doctor { Id = 2, FirstName = "Barış", LastName = "YİĞİT", Specialty = "internal Medicine Specialist", Age = "33", Address = "CELALİYE  Mah.Büyükçekmece/İstanbul", Phone = "05366325412" },
                new Doctor { Id = 3, FirstName = "Okan", LastName = "AYDIN", Specialty = "Gynecologist", Age = "51", Address = "Ayazağa Mah.Sarıyer/İstanbul", Phone = "05232143609" },
                new Doctor { Id = 4, FirstName = "Levent", LastName = "CAYMAZ", Specialty = "Plastic Surgery", Age = "43", Address = "Atatürk  Mah.Arnavutköy/İstanbul", Phone = "05328979878" },
                new Doctor { Id = 5, FirstName = "Büşra", LastName = "BERK", Specialty = "Pediatric Surgery", Age = "36", Address = "Şirinevler Mah.Bahçelievler/İstanbul", Phone = "05366478543" }

                );
        }
    }
}
