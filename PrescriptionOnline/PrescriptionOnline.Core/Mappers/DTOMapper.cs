using AutoMapper;
using PrescriptioOnline.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrescriptioOnline.Core
{
    public class DTOMappers
    {
        private IMapper _mapper;
        public DTOMappers()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<Medicine, MedicineDTO>().ForMember(x => x.PriceInTotal, opt => opt.MapFrom(y => y.Price * y.Amount)).ReverseMap();
                config.CreateMap<Prescription, PrescriptionDTO>().ReverseMap();
                config.CreateMap<Doctor, DoctorDTO>().ReverseMap();
            }).CreateMapper();
        }
        #region Medicine
        public MedicineDTO Map(Medicine medicine) => _mapper.Map<MedicineDTO>(medicine);
        public List<MedicineDTO> Map(List<Medicine> medicines) => _mapper.Map<List<MedicineDTO>>(medicines);
        public Medicine Map(MedicineDTO medicine) => _mapper.Map<Medicine>(medicine);
        public List<Medicine> Map(List<MedicineDTO> medicines) => _mapper.Map<List<Medicine>>(medicines);
        #endregion
        #region Doctor
        public DoctorDTO Map(Doctor Doctor) => _mapper.Map<DoctorDTO>(Doctor);
        public List<DoctorDTO> Map(List<Doctor> Doctors) => _mapper.Map<List<DoctorDTO>>(Doctors);
        public Doctor Map(DoctorDTO Doctor) => _mapper.Map<Doctor>(Doctor);
        public List<Doctor> Map(List<DoctorDTO> Doctors) => _mapper.Map<List<Doctor>>(Doctors);
        #endregion
        #region Prescription
        public PrescriptionDTO Map(Prescription Prescription) => _mapper.Map<PrescriptionDTO>(Prescription);
        public List<PrescriptionDTO> Map(List<Prescription> Prescriptions) => _mapper.Map<List<PrescriptionDTO>>(Prescriptions);
        public Prescription Map(PrescriptionDTO Prescription) => _mapper.Map<Prescription>(Prescription);
        public List<Prescription> Map(List<PrescriptionDTO> Prescriptions) => _mapper.Map<List<Prescription>>(Prescriptions);
        #endregion
    }
}
