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
        private readonly DoctorsMappers _doctorsMappers;
        public DoctorManager(IDoctorRepository doctorRepository, IPrescriptionRepository prescriptionRepository, IMedicineRepository medicineRepository, DoctorsMappers doctorsMappers)
        {
            _doctorRepository = doctorRepository;
            _prescriptionRepository = prescriptionRepository;
            _medicineRepository = medicineRepository;
            _doctorsMappers = doctorsMappers;
        }
        public IEnumerable<DoctorDTO> GetAllDoctors(string filterstring)
        {
            var doctorEntities = _doctorRepository.GetAllDoctors();
            if (!string.IsNullOrEmpty(filterstring))
            {
                doctorEntities = doctorEntities
                    .Where(x => x.FirstName.ToLower().Contains(filterstring.ToLower()) || x.LastName.ToLower().Contains(filterstring.ToLower()));
            }
            return _doctorsMappers.Map(doctorEntities);
        }
        public IEnumerable<PrescriptionDTO> GetAllPrescriptionForADoctor(int doctorId, string filterstring)
        {
            var prescriptionEntities = _prescriptionRepository.GetAllPrescriptions().Where(x => x.DoctorId == doctorId);
            if (!string.IsNullOrEmpty(filterstring))
            {
                prescriptionEntities = prescriptionEntities
                    .Where(x => x.Name.ToLower().Contains(filterstring.ToLower()));
            }
            return _doctorsMappers.Map(prescriptionEntities);
        }
        public IEnumerable<MedicineDTO> GetAllMedicineForAPrescription(int prescriptionId, string filterstring)
        {
            var medicineEntities = _medicineRepository.GetAllMedicines().Where(x => x.PrescriptionId == prescriptionId);
            if (!string.IsNullOrEmpty(filterstring))
            {
                medicineEntities = medicineEntities
                    .Where(x => x.Name.ToLower().Contains(filterstring.ToLower())
                             || x.ActiveSubstance.ToLower().Contains(filterstring.ToLower())
                             || x.Producent.ToLower().Contains(filterstring.ToLower()));
            }
            return _doctorsMappers.Map(medicineEntities);
        }
        public void AddNewMedicine(MedicineDTO medicine, int prescriptionId)
        {
            var entity = _doctorsMappers.Map(medicine);
            entity.PrescriptionId = prescriptionId;
            _medicineRepository.AddNew(entity);

        }
        public void AddNewPrescription(PrescriptionDTO prescription, int DoctorId)
        {
            var entity = _doctorsMappers.Map(prescription);
            entity.DoctorId = DoctorId;
            _prescriptionRepository.AddNew(entity);


        }
        public void AddNewDoctor(DoctorDTO doctor)
        {
            var entity = _doctorsMappers.Map(doctor);
            _doctorRepository.AddNew(entity);

        }

        public bool DeleteMedicine(MedicineDTO medicine)
        {
            var entity = _doctorsMappers.Map(medicine);
            return _medicineRepository.Delete(entity);

        }
        public bool DeletePrescription(PrescriptionDTO prescription)
        {
            var entity = _doctorsMappers.Map(prescription);
            return _prescriptionRepository.Delete(entity);


        }
        public bool DeleteDoctor(DoctorDTO doctor)
        {
            var entity = _doctorsMappers.Map(doctor);
            return _doctorRepository.Delete(entity);

        }
    }
}