using Microsoft.AspNetCore.Mvc;
using PrescriptionOnline.Models;
using PrescriptioOnline;
using PrescriptioOnline.Core;
using System.Linq;

namespace PrescriptionOnline.Controllers
{
    public class MedicineController : Controller
    {
        private readonly IDoctorManager _doctorManager;
        private readonly VMMapper _vMMapper;
        private static int PrescriptionId { get; set; }
        public MedicineController(IDoctorManager doctorManager, VMMapper vMMapper)
        {
            _doctorManager = doctorManager;
            _vMMapper = vMMapper;
        }

        public IActionResult Index(int doctorId, int prescriptionId, string filterString)
        {
            PrescriptionId = prescriptionId;

            var prescriptionDtos = _doctorManager.GetAllPrescriptionForADoctor(doctorId, filterString)
                                                 .FirstOrDefault(x=>x.Id==prescriptionId);

            var medicineDtos = _doctorManager.GetAllMedicineForAPrescription(prescriptionId, null);

            var prescriptionViewModels = _vMMapper.Map(prescriptionDtos);
            prescriptionViewModels.Medicines = _vMMapper.Map(medicineDtos);


            return View(prescriptionViewModels);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(MedicineViewModel medicineVm)
        {

            var dto = _vMMapper.Map(medicineVm);
            _doctorManager.AddNewMedicine(dto, PrescriptionId);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int medicineId)
        {
            _doctorManager.DeleteMedicine(new MedicineDTO { Id=medicineId});
            return View();
        }


    }
}

