using System.Collections.Generic;

namespace PrescriptionOnline.Models
{
    public class PrescriptionViewModel
    {
        public string Name { get; set; }
        public List<MedicineViewModel> Medicines { get; set; }
    }
}
