using System.Collections.Generic;

namespace PrescriptionOnline.Models
{
    public class DoctorViewModel
    {
        public string Name { get; set; }
        public List<PrescriptionViewModel> Prescriptions { get; set; }
    }
}
