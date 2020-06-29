
using System.Collections.Generic;

namespace PrescriptioOnline.Database
{
    public interface IDoctorRepository: IRepository<Doctor>
    {
         IEnumerable<Doctor> GetAllDoctors();
    }
}
