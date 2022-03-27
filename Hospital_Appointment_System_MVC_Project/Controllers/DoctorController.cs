using Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Interface;
using Hospital_Appointment_System_MVC_Project.Models.DTOs;
using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Hospital_Appointment_System_MVC_Project.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Appointment_System_MVC_Project.Controllers
{
    public class DoctorController : Controller
    {
        private IDoctorRepo _doctorRepo;

        public DoctorController(IDoctorRepo doctorRepo)
        {
            this._doctorRepo = doctorRepo;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DoctorCreateDTO model)
        {
            if (ModelState.IsValid)
            {
                Doctor doctor = new Doctor();
                doctor.FirstName = model.FirstName;
                doctor.LastName = model.LastName;
                doctor.Specialty = model.Specialty;
                doctor.Age = model.Age;
                doctor.Address = model.Address;
                doctor.Phone = model.Phone;


                _doctorRepo.Create(doctor);
                return RedirectToAction("List");


            }
            else
            {
                return View(model);
            }

        }

        public IActionResult List()
        {
            IEnumerable<DoctorListVM> patient = _doctorRepo.Gets().Select(x => new DoctorListVM { ID = x.Id, FirstName = x.FirstName, LastName = x.LastName, Specialty=x.Specialty, Age = x.Age });
            return View(patient);
        }

        public IActionResult Details(int ıd)
        {
            Doctor doctor = _doctorRepo.Get(x => x.Id == ıd);
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
            return View(vm);



        }

        public IActionResult Update(int id)
        {
            Doctor doctor = _doctorRepo.Get(X => X.Id == id);

            DoctorUpdateDTO model = new DoctorUpdateDTO();


            model.FirstName = doctor.FirstName;
            model.LastName = doctor.LastName;
            model.Specialty = doctor.Specialty;
            model.Age = doctor.Age;
            model.Address = doctor.Address;
            model.Phone = doctor.Phone;


            return View(model);
        }
        [HttpPost]
        public IActionResult Update(DoctorUpdateDTO model)
        {
            if (ModelState.IsValid)
            {

                Doctor doctor  = _doctorRepo.Get(x => x.Id == model.Id);
                doctor.FirstName = model.FirstName;
                doctor.LastName = model.LastName;
                doctor.Specialty = model.Specialty;
                doctor.Age = model.Age;
                doctor.Address = model.Address;
                doctor.Phone = model.Phone;


                _doctorRepo.Update(doctor);
                return RedirectToAction("List");


            }
            else
            {
                return View(model);
            }
        }



        public IActionResult Delete(int id)
        {
            Doctor doctor = _doctorRepo.Get(x => x.Id == id);
            _doctorRepo.Remove(doctor);
            return RedirectToAction("List");
        }
    }
}
