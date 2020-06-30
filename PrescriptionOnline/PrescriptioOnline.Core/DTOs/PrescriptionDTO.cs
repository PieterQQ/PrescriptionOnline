using System;
using System.Collections.Generic;
using System.Text;

namespace PrescriptioOnline.Core
{
    public class PrescriptionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }

        public int DoctorId { get; set; }
        public  DoctorDTO Doctor { get; set; }
        public List<MedicineDTO> Medicines { get; set; }
    }
}
