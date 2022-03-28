using Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Interface;
using Hospital_Appointment_System_MVC_Project.Infrastructure.Service;
using Hospital_Appointment_System_MVC_Project.Models.DTOs;
using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Hospital_Appointment_System_MVC_Project.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Appointment_System_MVC_Project.Controllers
{
    public class PatientController : Controller
    {

        private IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            this._patientService = patientService;
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
                _patientService.Create(model);
                return RedirectToAction("List");
            }
            else
            {
                return View(model);
            }

        }

        public IActionResult List()
        {
            return View(_patientService.GetAll());
        }

        public IActionResult Details(int id)
        { 
            return View(_patientService.GetDetails(id));
        }

        public IActionResult Update(int id)
        {

            return View(_patientService.Get(id));
        }
        [HttpPost]
        public IActionResult Update(PatientUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                _patientService.Update(model);
                return RedirectToAction("List");
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Delete(int id)
        {
      
            _patientService.Delete(id);
            return RedirectToAction("List");
        }

    }
}
