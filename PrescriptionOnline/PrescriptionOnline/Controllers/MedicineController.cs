using Microsoft.AspNetCore.Mvc;
using PrescriptionOnline.Models;
using System.Linq;

namespace PrescriptionOnline.Controllers
{
    public class MedicineController : Controller
    {

        private static int IndexOfDoctor { get; set; }
        private static int IndexOfPrescription { get; set; }
        public MedicineController()
        {
        
        }

        public IActionResult Index(int indexOfDoctor, int indexOfPrescription,string filterString)
        {
            IndexOfDoctor = indexOfDoctor;
            IndexOfPrescription = indexOfPrescription;
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
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(MedicineViewModel medicineVm)
        {
            TemporaryDatabase.Doctors.ElementAt(IndexOfDoctor)
                .Prescriptions.ElementAt(IndexOfPrescription)
                .Medicines.Add(medicineVm);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int indexOfMedicine)
        {
            return View();
        }


    }
}

