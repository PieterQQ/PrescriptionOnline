﻿using PrescriptioOnline.Database;
using System.Collections.Generic;
using System.Linq;

namespace PrescriptioOnline.Core
{


    public class DoctorManager : IDoctorManager
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IPrescriptionRepository _prescriptionRepository;
        private readonly IMedicineRepository _medicineRepository;
        private readonly DTOMappers _DTOMappers;
        public DoctorManager(IDoctorRepository doctorRepository, IPrescriptionRepository prescriptionRepository, IMedicineRepository medicineRepository, DTOMappers DTOMappers)
        {
            _doctorRepository = doctorRepository;
            _prescriptionRepository = prescriptionRepository;
            _medicineRepository = medicineRepository;
            _DTOMappers = DTOMappers;
        }
        public List<DoctorDTO> GetAllDoctors(string filterstring)
        {
            var doctorEntities = _doctorRepository.GetAllDoctors().ToList();
            if (!string.IsNullOrEmpty(filterstring))
            {
                doctorEntities = doctorEntities
                    .Where(x => x.FirstName.ToLower().Contains(filterstring.ToLower()) || x.LastName.ToLower().Contains(filterstring.ToLower())).ToList();
            }
            return _DTOMappers.Map(doctorEntities);
        }
        public List<PrescriptionDTO> GetAllPrescriptionForADoctor(int doctorId, string filterstring)
        {
            var prescriptionEntities = _prescriptionRepository.GetAllPrescriptions().Where(x => x.DoctorId == doctorId).ToList();
            if (!string.IsNullOrEmpty(filterstring))
            {
                prescriptionEntities = prescriptionEntities
                    .Where(x => x.Name.ToLower().Contains(filterstring.ToLower())).ToList();
            }
            return _DTOMappers.Map(prescriptionEntities);
        }
        public List<MedicineDTO> GetAllMedicineForAPrescription(int prescriptionId, string filterstring)
        {
            var medicineEntities = _medicineRepository.GetAllMedicines().Where(x => x.PrescriptionId == prescriptionId).ToList();
            if (!string.IsNullOrEmpty(filterstring))
            {
                medicineEntities = medicineEntities
                    .Where(x => x.Name.ToLower().Contains(filterstring.ToLower())
                             || x.ActiveSubstance.ToLower().Contains(filterstring.ToLower())
                             || x.Producent.ToLower().Contains(filterstring.ToLower())).ToList();
            }
            return _DTOMappers.Map(medicineEntities);
        }
        public void AddNewMedicine(MedicineDTO medicine, int prescriptionId)
        {
            var entity = _DTOMappers.Map(medicine);
            entity.PrescriptionId = prescriptionId;
            _medicineRepository.AddNew(entity);

        }
        public void AddNewPrescription(PrescriptionDTO prescription, int DoctorId)
        {
            var entity = _DTOMappers.Map(prescription);
            entity.DoctorId = DoctorId;
            _prescriptionRepository.AddNew(entity);


        }
        public void AddNewDoctor(DoctorDTO doctor)
        {
            var entity = _DTOMappers.Map(doctor);
            _doctorRepository.AddNew(entity);

        }
        
        public bool DeleteMedicine(MedicineDTO medicine)
        {
            var entity = _DTOMappers.Map(medicine);
            return _medicineRepository.Delete(entity);

        }
        public bool DeletePrescription(PrescriptionDTO prescription)
        {
            var entity = _DTOMappers.Map(prescription);
            return _prescriptionRepository.Delete(entity);


        }
        public bool DeleteDoctor(DoctorDTO doctor)
        {
            var entity = _DTOMappers.Map(doctor);
            return _doctorRepository.Delete(entity);

        }
        public bool EditDoctor(DoctorDTO doctor)
        {
            var entity = _DTOMappers.Map(doctor);
            return _doctorRepository.Edit(entity);

        }
    }
}
