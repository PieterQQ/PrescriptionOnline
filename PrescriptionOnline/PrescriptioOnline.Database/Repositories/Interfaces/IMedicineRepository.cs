using System.Collections.Generic;

namespace PrescriptioOnline.Database
{
    public interface IMedicineRepository: IRepository<Medicine>
    {
        IEnumerable<Medicine> GetAllMedicines();
    }
}
