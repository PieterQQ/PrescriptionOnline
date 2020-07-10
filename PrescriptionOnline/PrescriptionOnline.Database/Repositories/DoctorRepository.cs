using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PrescriptioOnline.Database
{
    public class DoctorRepository :BaseRepository<Doctor>,IDoctorRepository
    {
        protected override DbSet<Doctor> DbSet => _DbContext.Doctors;
        public DoctorRepository(PrescriptionOnlineDbContext dbContext) : base(dbContext)
        {

        }
        public IEnumerable<Doctor> GetAllDoctors()
        {
            return DbSet.Select(x => x);
        }

        public Doctor GetDoctor(int doctorId)
        {
            return DbSet.First(x => x.Id == doctorId);
        }
    }
}
