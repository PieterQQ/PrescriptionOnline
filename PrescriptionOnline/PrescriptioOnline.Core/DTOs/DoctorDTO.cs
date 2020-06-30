using System.Collections.Generic;

namespace PrescriptioOnline.Core
{
    public class DoctorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsAbleToMakePrescriptions { get; set; }
        public IEnumerable<PrescriptionDTO> Prescriptions { get; set; }
    }
}
