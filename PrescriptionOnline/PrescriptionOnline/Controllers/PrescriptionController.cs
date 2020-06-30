using Microsoft.AspNetCore.Mvc;
using PrescriptionOnline.Models;
using PrescriptioOnline;
using PrescriptioOnline.Core;
using System.Linq;

namespace PrescriptionOnline.Controllers
{
    public class PrescriptionController : Controller
    {
        private readonly IDoctorManager _doctorManager;
        private readonly VMMapper _vMMapper;
        private static int DoctorId { get; set; }
        public PrescriptionController(IDoctorManager doctorManager, VMMapper vMMapper)
        {
            _doctorManager = doctorManager;
            _vMMapper = vMMapper;
        }

        public IActionResult Index(int doctorId, string filterString)
        {
            DoctorId = doctorId;
            var doctorDtos = _doctorManager.GetAllDoctors(null)
                                                .FirstOrDefault(x => x.Id == doctorId);

            var prescriptionDtos = _doctorManager.GetAllPrescriptionForADoctor(doctorId, filterString);

            var doctorViewModels = _vMMapper.Map(doctorDtos);
            doctorViewModels.Prescriptions = _vMMapper.Map(prescriptionDtos);


            return View(doctorViewModels);
        }

        public IActionResult View(int prescriptionId)
        {
            return RedirectToAction("Index", "Medicine", new { doctorId = DoctorId, prescriptionId = prescriptionId }); 
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(PrescriptionViewModel prescriptionVm)
        {
            var dto = _vMMapper.Map(prescriptionVm);
            _doctorManager.AddNewPrescription(dto, DoctorId);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int prescriptionId)
        {
            _doctorManager.DeletePrescription(new PrescriptionDTO { Id = prescriptionId });
            return View();
        }


    }
}
