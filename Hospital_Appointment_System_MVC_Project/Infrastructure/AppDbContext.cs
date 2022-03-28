using Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration;
using Hospital_Appointment_System_MVC_Project.Infrastructure.SeedData;
using Hospital_Appointment_System_MVC_Project.Infrastructure.Utilities;
using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());

            modelBuilder.ApplyConfiguration(new DoctorSeed());
            modelBuilder.ApplyConfiguration(new PatientSeed());
            modelBuilder.ApplyConfiguration(new AppointmentSeed());



            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {

            var entityEntities = ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted);

            string computerName = Environment.MachineName;
            DateTime datetime = DateTime.Now;
            string ip = RemoteIP.IpAddress;

            foreach (var item in entityEntities)
            {
                BaseEntity entity = item.Entity as BaseEntity;

                switch (item.State)
                {

                    case EntityState.Deleted:
                        entity.DeletedDate = datetime;
                        entity.DeletedIpAddress = ip;
                        entity.DeletedMachineName = computerName;
                        break;
                    case EntityState.Modified:

                        entity.UpdateDate = datetime;
                        entity.UpdateIpAddress = ip;
                        entity.UpdateMachineName = computerName;
                        break;
                    case EntityState.Added:
                        entity.CreateDate = datetime;
                        entity.CreatedIpAddress = ip;
                        entity.CreatedMachineName = computerName;

                        break;

                }


            }


            return base.SaveChanges();

        }
 
    }
}
