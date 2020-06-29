using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace PrescriptioOnline.Database
{
    public class PrescriptionOnlineDbContext : DbContext
    {
        public PrescriptionOnlineDbContext(DbContextOptions options):base(options)
        {

        }
    }
}
