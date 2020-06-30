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
        public IEnumerable<MedicineDTO> Map(IEnumerable<Medicine> medicines) => _mapper.Map<IEnumerable<MedicineDTO>>(medicines);
        public Medicine Map(MedicineDTO medicine) => _mapper.Map<Medicine>(medicine);
        public IEnumerable<Medicine> Map(IEnumerable<MedicineDTO> medicines) => _mapper.Map<IEnumerable<Medicine>>(medicines);
        #endregion
        #region Doctor
        public DoctorDTO Map(Doctor Doctor) => _mapper.Map<DoctorDTO>(Doctor);
        public IEnumerable<DoctorDTO> Map(IEnumerable<Doctor> Doctors) => _mapper.Map<IEnumerable<DoctorDTO>>(Doctors);
        public Doctor Map(DoctorDTO Doctor) => _mapper.Map<Doctor>(Doctor);
        public IEnumerable<Doctor> Map(IEnumerable<DoctorDTO> Doctors) => _mapper.Map<IEnumerable<Doctor>>(Doctors);
        #endregion
        #region Prescription
        public PrescriptionDTO Map(Prescription Prescription) => _mapper.Map<PrescriptionDTO>(Prescription);
        public IEnumerable<PrescriptionDTO> Map(IEnumerable<Prescription> Prescriptions) => _mapper.Map<IEnumerable<PrescriptionDTO>>(Prescriptions);
        public Prescription Map(PrescriptionDTO Prescription) => _mapper.Map<Prescription>(Prescription);
        public IEnumerable<Prescription> Map(IEnumerable<PrescriptionDTO> Prescriptions) => _mapper.Map<IEnumerable<Prescription>>(Prescriptions);
        #endregion
    }
}
