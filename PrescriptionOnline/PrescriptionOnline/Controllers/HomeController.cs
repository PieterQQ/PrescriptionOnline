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

        public IActionResult Index()
        {
            return View(TemporaryDatabase.Doctors);
        }

        public IActionResult View(int indexOfDoctor)
        {
            return RedirectToAction ("Index","Prescription", new { indexOfDoctor=indexOfDoctor });
        }

        public IActionResult Delete(int indexOfDoctor)
        {
            return View(TemporaryDatabase.Doctors);
        }



    }
}
