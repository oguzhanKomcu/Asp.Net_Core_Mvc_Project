using Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Interface;
using Hospital_Appointment_System_MVC_Project.Models.DTOs;
using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Hospital_Appointment_System_MVC_Project.Models.VMs;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.Service
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepo _appointmentRepo;
        private readonly IPatientRepo _patientRepo;
        private readonly IDoctorRepo _doctorRepo;

        public AppointmentService(IAppointmentRepo appointmentRepo, IPatientRepo patientRepo, IDoctorRepo doctorRepo)
        {
            _appointmentRepo = appointmentRepo;
            _patientRepo = patientRepo;
            _doctorRepo = doctorRepo;
        }
        

        
        public void Create(AppointmentCreateDTO model)
        {
            Appointment appointment = new Appointment();
            appointment.Doctor_Id = model.Doctor_Id;
            appointment.Patient_Id = model.Patient_Id;
            appointment.Date = model.Date;
            appointment.Time = model.Time;
            appointment.Reason = model.Reason;
            appointment.Prescription = model.Prescription;

            _appointmentRepo.Create(appointment);
            



        }

        public AppointmentUpdateDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> Gets()
        {
            List<Appointment> appointmentS = _appointmentRepo.Gets().ToList();
           
            return appointmentS;
        }
      
         

        public AppointmentCreateDTO GetPatientDoctor()
        {
            AppointmentCreateDTO model = new AppointmentCreateDTO();
            model.PatientListVMs = _patientRepo.Gets()
                                     .Select(x => new PatientListVM
                                     {
                                         ID = x.Id,
                                         FirstName = x.FirstName,
                                         LastName = x.LastName
                                     });
            
            model.DoctorListVMs = _doctorRepo.Gets()
                                     .Select(x => new DoctorListVM
                                     {
                                         ID = x.Id,
                                         FirstName = x.FirstName,
                                         LastName = x.LastName
                                     });
            return model;
        }

        public void Delete(int id)
        {
            Appointment appointment = _appointmentRepo.Get(x => x.Id == id);
            _appointmentRepo.Remove(appointment);
        }

        public AppointmentDetailsVM GetDetails(int id)
        {
            AppointmentDetailsVM model = new AppointmentDetailsVM();
            Appointment appointment = _appointmentRepo.Get(x => x.Id == id);
            model.Id = appointment.Id;
            model.Doctor_Id = appointment.Doctor_Id;
            model.Patient_Id = appointment.Patient_Id;
            model.Date = appointment.Date;
            model.Time = appointment.Time;
            model.Reason = appointment.Reason;
            model.Prescription = appointment.Prescription;
            return model;

        }
    }
}
