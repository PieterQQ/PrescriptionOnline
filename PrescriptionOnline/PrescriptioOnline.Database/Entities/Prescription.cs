using System;

namespace PrescriptioOnline.Database
{
    public class Prescription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
