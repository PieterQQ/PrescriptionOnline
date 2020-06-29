using Microsoft.AspNetCore.Mvc;
using PrescriptionOnline.Models;
using System.Linq;

namespace PrescriptionOnline.Controllers
{
    public class MedicineController : Controller
    {
    

        public MedicineController()
        {
        
        }

        public IActionResult Index(int indexOfDoctor, int indexOfPrescription)
        {
            return View(TemporaryDatabase.Doctors.ElementAt(indexOfDoctor).Prescriptions.ElementAt(indexOfPrescription));
        }

        public IActionResult Delete(int indexOfMedicine)
        {
            return View();
        }


    }
}

