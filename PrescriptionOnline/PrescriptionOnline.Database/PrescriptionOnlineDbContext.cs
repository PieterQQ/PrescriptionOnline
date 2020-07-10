using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace PrescriptioOnline.Database
{
    public class PrescriptionOnlineDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public PrescriptionOnlineDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
