using Microsoft.AspNetCore.Mvc;
using PrescriptionOnline.Models;
using System.Linq;

namespace PrescriptionOnline.Controllers
{
    public class PrescriptionController : Controller
    {
        private int IndexOfDoctor { get; set; }

        public PrescriptionController()
        {

        }

        public IActionResult Index(int indexOfDoctor)
        {
            IndexOfDoctor = indexOfDoctor;
          return View(TemporaryDatabase.Doctors.ElementAt(indexOfDoctor));
        }

        public IActionResult View(int indexOfPrescription)
        {
            return RedirectToAction("Index", "Medicine", new { indexOfDoctor = IndexOfDoctor, indexOfPrescription = indexOfPrescription }); ;
        }

        public IActionResult Delete(int indexOfPrescription)
        {
            return View();
        }


    }
}
