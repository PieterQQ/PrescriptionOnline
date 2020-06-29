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

        public IActionResult Index(int indexOfDoctor, int indexOfPrescription,string filterString)
        {
            if (string.IsNullOrEmpty(filterString))
            {
                return View(TemporaryDatabase.Doctors.ElementAt(indexOfDoctor).Prescriptions.ElementAt(indexOfPrescription));
            }
            return View(new PrescriptionViewModel { 
           
                Name = TemporaryDatabase.Doctors.ElementAt(indexOfDoctor).Prescriptions.ElementAt(indexOfPrescription).Name,
                Medicines = TemporaryDatabase.Doctors.ElementAt(indexOfDoctor).Prescriptions.ElementAt(indexOfPrescription)
                                                .Medicines.Where(x => x.Name.ToLower()
                                                   .Contains(filterString.ToLower())).ToList()
            });
        }

        public IActionResult Delete(int indexOfMedicine)
        {
            return View();
        }


    }
}

