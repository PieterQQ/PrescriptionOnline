using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrescriptioOnline.Database
{
    public class MedicineRepository :BaseRepository<Medicine>,IMedicineRepository
    {
        protected override DbSet<Medicine> DbSet => _DbContext.Medicines;
        public MedicineRepository(PrescriptionOnlineDbContext dbContext) : base(dbContext)
        {

        }
    }
}
