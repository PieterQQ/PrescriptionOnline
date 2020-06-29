using System;
using System.Collections.Generic;
using System.Text;

namespace PrescriptioOnline.Database
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsAbleToMakePrescriptions { get; set; }

    }
}
