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
        IEnumerable<DoctorDTO> GetAllDoctors(string filterstring);
        IEnumerable<MedicineDTO> GetAllMedicineForAPrescription(int prescriptionId, string filterstring);
        IEnumerable<PrescriptionDTO> GetAllPrescriptionForADoctor(int doctorId, string filterstring);
    }
}
