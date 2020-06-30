using Microsoft.AspNetCore.Mvc;
using PrescriptionOnline.Models;
using PrescriptioOnline;
using PrescriptioOnline.Core;
using System.Collections.Generic;
using System.Linq;

namespace PrescriptionOnline.Controllers
{
    public class HomeController : Controller
    {

        private readonly IDoctorManager _doctorManager;
        private readonly VMMapper _vMMapper;

        public HomeController(IDoctorManager doctorManager, VMMapper vMMapper)
        {
            _doctorManager = doctorManager;
            _vMMapper = vMMapper;
        }

        public IActionResult Index(string filterString)
        {
            var doctorDtos = _doctorManager.GetAllDoctors(filterString);
            var doctorViewModels = _vMMapper.Map(doctorDtos);
            return View(doctorViewModels);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(DoctorViewModel doctorVm)
        {
            var dto = _vMMapper.Map(doctorVm);
            _doctorManager.AddNewDoctor(dto);
            return RedirectToAction("Index");
        }
        public IActionResult View(int doctorId)
        {
            return RedirectToAction ("Index","Prescription", new { doctorId= doctorId });
        }

        public IActionResult Delete(int doctorId)
        {
            _doctorManager.DeleteDoctor(new DoctorDTO { Id = doctorId });
            var doctorDtos = _doctorManager.GetAllDoctors(null);
            var doctorViewModels = _vMMapper.Map(doctorDtos);
            return RedirectToAction("Index");
        }



    }
}
