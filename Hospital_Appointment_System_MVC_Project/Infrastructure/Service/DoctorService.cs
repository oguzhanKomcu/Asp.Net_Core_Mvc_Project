using Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Interface;
using Hospital_Appointment_System_MVC_Project.Models.DTOs;
using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Hospital_Appointment_System_MVC_Project.Models.VMs;

namespace Hospital_Appointment_System_MVC_Project.Infrastructure.Service
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepo _doctorRepo;
        public DoctorService(IDoctorRepo doctorRepo)
        {
            _doctorRepo = doctorRepo;
        }   
        
        
        public void Create(DoctorCreateDTO model)
        {

            Doctor doctor = new Doctor();
            doctor.FirstName = model.FirstName;
            doctor.LastName = model.LastName;
            doctor.Specialty = model.Specialty;
            doctor.Age = model.Age;
            doctor.Address = model.Address;
            doctor.Phone = model.Phone;
        }

        public void Delete(int id)
        {
            Doctor doctor = _doctorRepo.Get(x => x.Id == id);
            _doctorRepo.Remove(doctor);
        }

        public DoctorUpdateDTO Get(int id)
        {
            Doctor doctor = _doctorRepo.Get(X => X.Id == id);

            DoctorUpdateDTO model = new DoctorUpdateDTO();


            model.FirstName = doctor.FirstName;
            model.LastName = doctor.LastName;
            model.Specialty = doctor.Specialty;
            model.Age = doctor.Age;
            model.Address = doctor.Address;
            model.Phone = doctor.Phone;
            return model;
        }

        public IEnumerable<DoctorListVM> GetAll()
        {
            IEnumerable<DoctorListVM> patient = _doctorRepo.Gets().Select(x => new DoctorListVM { ID = x.Id, FirstName = x.FirstName, LastName = x.LastName, Specialty = x.Specialty, Age = x.Age });
            return patient;
        }

        public DoctorDetailsVM GetDetails(int id)
        {
            Doctor doctor = _doctorRepo.Get(x => x.Id == id);
            DoctorDetailsVM vm = new DoctorDetailsVM();
            vm.Id = doctor.Id;
            vm.FirstName = doctor.FirstName;
            vm.LastName = doctor.LastName;
            vm.Specialty = doctor.Specialty;
            vm.Age = doctor.Age;
            vm.Phone = doctor.Phone;
            vm.Address = doctor.Address;
            vm.CreateDate = doctor.CreateDate;
            vm.CreatedIpAddress = doctor.CreatedIpAddress;
            vm.CreatedMachineName = doctor.CreatedMachineName;
            vm.UpdateDate = doctor.UpdateDate;
            vm.UpdateIpAddress = doctor.UpdateIpAddress;
            vm.UpdateMachineName = doctor.UpdateMachineName;
            vm.DeletedDate = doctor.DeletedDate;
            vm.DeletedIpAddress = doctor.DeletedIpAddress;
            vm.DeletedMachineName = doctor.DeletedMachineName;
            return vm;
        }

        public void Update(DoctorUpdateDTO model)
        {
            
            Doctor doctor = _doctorRepo.Get(x => x.Id == model.Id);
            doctor.FirstName = model.FirstName;
            doctor.LastName = model.LastName;
            doctor.Specialty = model.Specialty;
            doctor.Age = model.Age;
            doctor.Address = model.Address;
            doctor.Phone = model.Phone;
            
        }
    }
}
