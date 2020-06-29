using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrescriptioOnline.Database
{
    public class DoctorRepository :BaseRepository<Doctor>,IDoctorRepository
    {
        protected override DbSet<Doctor> DbSet => _DbContext.Doctors;
        public DoctorRepository(PrescriptionOnlineDbContext dbContext) : base(dbContext)
        {

        }
    }
}
