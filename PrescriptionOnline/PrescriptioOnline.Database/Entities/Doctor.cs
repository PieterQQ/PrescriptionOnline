using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrescriptioOnline.Database
{
    public class Doctor : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        [NotMapped]
        public virtual IEnumerable<Prescription> Prescriptions { get; set; }

    }
}
