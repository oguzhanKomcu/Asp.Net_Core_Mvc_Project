using Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Interface;
using Hospital_Appointment_System_MVC_Project.Models.DTOs;
using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Hospital_Appointment_System_MVC_Project.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Appointment_System_MVC_Project.Controllers
{
    public class PatientController : Controller
    {

        private IPatientRepo _patientRepo;

        public PatientController(IPatientRepo patientRepo)
        {
            this._patientRepo = patientRepo;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PatientCreateDTO model)
        {
            if (ModelState.IsValid)
            {
                Patient patient = new Patient();
                patient.FirstName = model.FirstName;
                patient.LastName = model.LastName;
                patient.Identity_No = model.Identity_No;
                patient.Age = model.Age;
                patient.Address = model.Address;
                patient.Phone = model.Phone;


                _patientRepo.Create(patient);
                return RedirectToAction("List");


            }
            else
            {
                return View(model);
            }

        }

        public IActionResult List()
        {
            IEnumerable<PatientListVM> patient = _patientRepo.Gets().Select(x => new PatientListVM { ID = x.Id, FirstName = x.FirstName, LastName = x.LastName, Identity_No = x.Identity_No, Age = x.Age});
            return View(patient);
        }

        public IActionResult Details(int ıd)
        {
            Patient patient = _patientRepo.Get(x => x.Id == ıd);
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
            return View(vm);



        }

        public IActionResult Update(int id)
        {
            Patient patient = _patientRepo.Get(X => X.Id == id);

            PatientUpdateDTO model = new PatientUpdateDTO();


            model.FirstName = patient.FirstName;
            model.LastName = patient.LastName;
            model.Identity_No = patient.Identity_No;
            model.Age = patient.Age;
            model.Address = patient.Address;
            model.Phone = patient.Phone;


            return View(model);
        }
        [HttpPost]
        public IActionResult Update(PatientUpdateDTO model)
        {
            if (ModelState.IsValid)
            {

                Patient patient = _patientRepo.Get(x =>  x.Id == model.Id); 
                patient.FirstName = model.FirstName;
                patient.LastName = model.LastName;
                patient.Identity_No = model.Identity_No;
                patient.Age = model.Age;
                patient.Address = model.Address;
                patient.Phone = model.Phone;


                _patientRepo.Update(patient);
                return RedirectToAction("List");


            }
            else
            {
                return View(model);
            }
        }

     

        public IActionResult Delete(int id)
        {
            Patient patient = _patientRepo.Get(x => x.Id == id);
            _patientRepo.Remove(patient);
            return RedirectToAction("List");
        }

    }
}
