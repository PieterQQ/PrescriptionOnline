using Microsoft.AspNetCore.Mvc;
using PrescriptionOnline.Models;
using System.Collections.Generic;
using System.Linq;

namespace PrescriptionOnline.Controllers
{
    public class HomeController : Controller
    {

        
        public HomeController()
        {
            
        }

        public IActionResult Index(string filterString)
        {
            if (string.IsNullOrEmpty(filterString))
            {
                return View(TemporaryDatabase.Doctors);
            }
            return View(TemporaryDatabase.Doctors.Where(x => x.Name.ToLower().Contains(filterString.ToLower())).ToList());
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(DoctorViewModel doctorVm)
        {
            TemporaryDatabase.Doctors.Add(doctorVm);
            return RedirectToAction("Index");
        }
        public IActionResult View(int indexOfDoctor)
        {
            return RedirectToAction ("Index","Prescription", new {indexOfDoctor });
        }

        public IActionResult Delete(int indexOfDoctor)
        {
            return View(TemporaryDatabase.Doctors);
        }



    }
}
