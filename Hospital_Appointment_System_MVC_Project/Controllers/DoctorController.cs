using Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Interface;
using Hospital_Appointment_System_MVC_Project.Infrastructure.Service;
using Hospital_Appointment_System_MVC_Project.Models.DTOs;
using Hospital_Appointment_System_MVC_Project.Models.Entities;
using Hospital_Appointment_System_MVC_Project.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Appointment_System_MVC_Project.Controllers
{
    public class DoctorController : Controller
    {
        private IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            this._doctorService = doctorService;
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
                _doctorService.Create(model);
                return RedirectToAction("List");
            }
            else
            {
                return View(model);
            }

        }

        public IActionResult List()
        {

            return View(_doctorService.GetAll());
        }

        public IActionResult Details(int id)
        {

            return View(_doctorService.GetDetails(id));
        }

        public IActionResult Update(int id)
        {

            return View(_doctorService.Get(id));
        }
        [HttpPost]
        public IActionResult Update(DoctorUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                _doctorService.Update(model);
                return RedirectToAction("List");
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Delete(int id)
        {
            _doctorService.Delete(id);
            return RedirectToAction("List");
        }
    }
}
