using System;
using System.Collections.Generic;
using System.Text;

namespace PrescriptioOnline.Core
{
    public class MedicineDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producent { get; set; }
        public string ActiveSubstance { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public DateTime ExpirationDate { get; set; }
        public  PrescriptionDTO Prescription { get; set; }
    }
}
