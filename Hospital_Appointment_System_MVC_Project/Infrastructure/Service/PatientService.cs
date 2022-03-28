using Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Interface;
using Hospital_Appointment_System_MVC_Project.Models.DTOs;
using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Hospital_Appointment_System_MVC_Project.Models.VMs;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.Service
{
    public class PatientService : IPatientService
    {

        private readonly IPatientRepo _patientRepo;

        public PatientService(IPatientRepo patientRepo)
        {
            this._patientRepo = patientRepo;
        }
        

        
        public void Create(PatientCreateDTO model)
        {
            Patient patient = new Patient();
            patient.FirstName = model.FirstName;
            patient.LastName = model.LastName;
            patient.Identity_No = model.Identity_No;
            patient.Age = model.Age;
            patient.Address = model.Address;
            patient.Phone = model.Phone;
        }

        public void Delete(int id)
        {
            Patient patient = _patientRepo.Get(x => x.Id == id);
            _patientRepo.Remove(patient);
        }

        public PatientUpdateDTO Get(int id)
        {
            Patient patient = _patientRepo.Get(X => X.Id == id);

            PatientUpdateDTO model = new PatientUpdateDTO();


            model.FirstName = patient.FirstName;
            model.LastName = patient.LastName;
            model.Identity_No = patient.Identity_No;
            model.Age = patient.Age;
            model.Address = patient.Address;
            model.Phone = patient.Phone;
            return model;
        }

        public IEnumerable<PatientListVM> GetAll()
        {
            IEnumerable<PatientListVM> patient = _patientRepo.Gets().Select(x => new PatientListVM { ID = x.Id, FirstName = x.FirstName, LastName = x.LastName, Identity_No = x.Identity_No, Age = x.Age });
            return patient;
        }

        public PatientDetailsVM GetDetails(int id)
        {
            Patient patient = _patientRepo.Get(x => x.Id == id);
            PatientDetailsVM vm = new PatientDetailsVM();
            vm.ID = patient.Id;
            vm.FirstName = patient.FirstName;
            vm.LastName = patient.LastName;
            vm.Identity_No = patient.Identity_No;
            vm.Age = patient.Age;
            vm.Phone = patient.Phone;
            vm.Address = patient.Address;
            vm.CreateDate = patient.CreateDate;
            vm.CreatedIpAddress = patient.CreatedIpAddress;
            vm.CreatedMachineName = patient.CreatedMachineName;
            vm.UpdateDate = patient.UpdateDate;
            vm.UpdateIpAddress = patient.UpdateIpAddress;
            vm.UpdateMachineName = patient.UpdateMachineName;
            vm.DeletedDate = patient.DeletedDate;
            vm.DeletedIpAddress = patient.DeletedIpAddress;
            vm.DeletedMachineName = patient.DeletedMachineName;
            return vm;
        }

        public void Update(PatientUpdateDTO model)
        {

            Patient patient = _patientRepo.Get(x => x.Id == model.Id);
            patient.FirstName = model.FirstName;
            patient.LastName = model.LastName;
            patient.Identity_No = model.Identity_No;
            patient.Age = model.Age;
            patient.Address = model.Address;
            patient.Phone = model.Phone;
        }
    }
}
