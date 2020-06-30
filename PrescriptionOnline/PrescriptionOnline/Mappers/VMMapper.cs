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
        public IEnumerable<MedicineViewModel> Map(IEnumerable<MedicineDTO> medicines) => _mapper.Map<IEnumerable<MedicineViewModel>>(medicines);
        public MedicineDTO Map(MedicineViewModel medicine) => _mapper.Map<MedicineDTO>(medicine);
        public IEnumerable<MedicineDTO> Map(IEnumerable<MedicineViewModel> medicines) => _mapper.Map<IEnumerable<MedicineDTO>>(medicines);
        #endregion
        #region Doctor
        public DoctorViewModel Map(DoctorDTO Doctor) => _mapper.Map<DoctorViewModel>(Doctor);
        public IEnumerable<DoctorViewModel> Map(IEnumerable<DoctorDTO> Doctors) => _mapper.Map<IEnumerable<DoctorViewModel>>(Doctors);
        public DoctorDTO Map(DoctorViewModel Doctor) => _mapper.Map<DoctorDTO>(Doctor);
        public IEnumerable<DoctorDTO> Map(IEnumerable<DoctorViewModel> Doctors) => _mapper.Map<IEnumerable<DoctorDTO>>(Doctors);
        #endregion
        #region Prescription
        public PrescriptionViewModel Map(PrescriptionDTO Prescription) => _mapper.Map<PrescriptionViewModel>(Prescription);
        public IEnumerable<PrescriptionViewModel> Map(IEnumerable<PrescriptionDTO> Prescriptions) => _mapper.Map<IEnumerable<PrescriptionViewModel>>(Prescriptions);
        public PrescriptionDTO Map(PrescriptionViewModel Prescription) => _mapper.Map<PrescriptionDTO>(Prescription);
        public IEnumerable<PrescriptionDTO> Map(IEnumerable<PrescriptionViewModel> Prescriptions) => _mapper.Map<IEnumerable<PrescriptionDTO>>(Prescriptions);
        #endregion
    }
}
