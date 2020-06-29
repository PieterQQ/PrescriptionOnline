using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrescriptioOnline.Database
{
    public class PrescriptionRepository :  BaseRepository<Prescription>,IPrescriptionRepository
    {
        protected override DbSet<Prescription> DbSet => _DbContext.Prescriptions;
        public PrescriptionRepository(PrescriptionOnlineDbContext dbContext) : base(dbContext)
        {

        }
        public IEnumerable<Prescription> GetAllPrescriptions()
        {
            return DbSet.Include(x=>x.Medicines).Select(x => x);
        }
       
    }
}
