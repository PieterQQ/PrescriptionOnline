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

        public IActionResult Index(int indexOfDoctor, string filterString)
        {
            IndexOfDoctor = indexOfDoctor;
            if (string.IsNullOrEmpty(filterString))
            {
                return View(TemporaryDatabase.Doctors.ElementAt(indexOfDoctor));
            }
            return View(new DoctorViewModel 
            {
                Name = TemporaryDatabase.Doctors.ElementAt(indexOfDoctor).Name,
                Prescriptions = TemporaryDatabase.Doctors.ElementAt(indexOfDoctor)
                                                 .Prescriptions.Where(x => x.Name.ToLower()
                                                    .Contains(filterString.ToLower())).ToList()
            });
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
