using System.Collections.Generic;

namespace PrescriptioOnline.Core
{
    public interface IDoctorManager
    {
        void AddNewDoctor(DoctorDTO doctor);
        void AddNewMedicine(MedicineDTO medicine, int prescriptionId);
        void AddNewPrescription(PrescriptionDTO prescription, int DoctorId);
        bool DeleteDoctor(DoctorDTO doctor);
        bool DeleteMedicine(MedicineDTO medicine);
        bool DeletePrescription(PrescriptionDTO prescription);
        List<DoctorDTO> GetAllDoctors(string filterstring);
        List<MedicineDTO> GetAllMedicineForAPrescription(int prescriptionId, string filterstring);
        List<PrescriptionDTO> GetAllPrescriptionForADoctor(int doctorId, string filterstring);
    }
}
