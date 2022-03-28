using Hospital_Appointment_System_MVC_Project.Infrastructure.EntityTypeConfiguration.Repositories.Interface;
using Hospital_Appointment_System_MVC_Project.Infrastructure.Service;
using Hospital_Appointment_System_MVC_Project.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Appointment_System_MVC_Project.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }   
        
        
        [HttpGet]
        public IActionResult Create()
        {
            AppointmentCreateDTO model = _appointmentService.GetPatientDoctor();


            return View(model);
        }

        [HttpPost]
        public IActionResult Create(AppointmentCreateDTO model)
        {
            if (ModelState.IsValid)
            {
                _appointmentService.Create(model);
            
                return RedirectToAction("List");
            }
            else
            {
                return View(model);
            }
            
        }
        public IActionResult List()
        {
            return View(_appointmentService.Gets());
        }

        public IActionResult Delete(int id)
        {
            _appointmentService.Delete(id);
            return RedirectToAction("List");
        }

        public IActionResult Details(int id)
        {
            return View(_appointmentService.GetDetails(id));
        }
    }
}
