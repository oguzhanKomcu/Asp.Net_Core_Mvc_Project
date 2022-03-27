using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.SeedData
{
    public class PatientSeed : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasData(

                new Patient { Id = 1, FirstName = "Oğuzhan", LastName = "KÖMCÜ", Identity_No = "68795435210", Age = "26", Address = "İnönü Mah.Küçükçekmece/İstanbul", Phone = "05356548789" },
                new Patient { Id = 2, FirstName = "Ozan", LastName = "SAĞLAM", Identity_No = "55523698745", Age = "35", Address = "Çukur Mah.Fatih/İstanbul", Phone = "05321463625" },
                new Patient { Id = 3, FirstName = "Gamze", LastName = "KURT", Identity_No = "25478965412", Age = "75", Address = "Çobançeşme Mah.Bağcılar/İstanbul", Phone = "05312145326" },
                new Patient { Id = 4, FirstName = "Elif", LastName = "DUMAN", Identity_No = "21032547801", Age = "22", Address = "Kartaltepe  Mah.Bakırköy/İstanbul", Phone = "05326898587" },
                new Patient { Id = 5, FirstName = "Mertcan", LastName = "TUNA", Identity_No = "21304156987", Age = "10", Address = "Cumhuriyet Mah.Bahçelievler/İstanbul", Phone = "05365532284" }





                );
        }
    }
}

