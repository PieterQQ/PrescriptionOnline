using AutoMapper;
using PrescriptionOnline.Models;
using PrescriptioOnline.Core;
using System.Collections.Generic;

namespace PrescriptioOnline
{
    public class VMMapper
    {
        private IMapper _mapper;
        public VMMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<MedicineDTO, MedicineViewModel>().ReverseMap();
                config.CreateMap<PrescriptionDTO, PrescriptionViewModel>().ReverseMap();
                config.CreateMap<DoctorDTO, DoctorViewModel>().ReverseMap();
            }).CreateMapper();
        }
        #region Medicine
        public MedicineViewModel Map(MedicineDTO medicine) => _mapper.Map<MedicineViewModel>(medicine);
        public List<MedicineViewModel> Map(List<MedicineDTO> medicines) => _mapper.Map<List<MedicineViewModel>>(medicines);
        public MedicineDTO Map(MedicineViewModel medicine) => _mapper.Map<MedicineDTO>(medicine);
        public List<MedicineDTO> Map(List<MedicineViewModel> medicines) => _mapper.Map<List<MedicineDTO>>(medicines);
        #endregion
        #region Doctor
        public DoctorViewModel Map(DoctorDTO Doctor) => _mapper.Map<DoctorViewModel>(Doctor);
        public List<DoctorViewModel> Map(List<DoctorDTO> Doctors) => _mapper.Map<List<DoctorViewModel>>(Doctors);
        public DoctorDTO Map(DoctorViewModel Doctor) => _mapper.Map<DoctorDTO>(Doctor);
        public List<DoctorDTO> Map(List<DoctorViewModel> Doctors) => _mapper.Map<List<DoctorDTO>>(Doctors);
        #endregion
        #region Prescription
        public PrescriptionViewModel Map(PrescriptionDTO Prescription) => _mapper.Map<PrescriptionViewModel>(Prescription);
        public List<PrescriptionViewModel> Map(List<PrescriptionDTO> Prescriptions) => _mapper.Map<List<PrescriptionViewModel>>(Prescriptions);
        public PrescriptionDTO Map(PrescriptionViewModel Prescription) => _mapper.Map<PrescriptionDTO>(Prescription);
        public List<PrescriptionDTO> Map(List<PrescriptionViewModel> Prescriptions) => _mapper.Map<List<PrescriptionDTO>>(Prescriptions);
        #endregion
    }
}
