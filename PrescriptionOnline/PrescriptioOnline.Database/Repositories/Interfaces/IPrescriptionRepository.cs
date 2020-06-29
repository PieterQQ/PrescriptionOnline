using System.Collections.Generic;

namespace PrescriptioOnline.Database
{
    public interface IPrescriptionRepository: IRepository<Prescription>
    {
        IEnumerable<Prescription> GetAllPrescriptions();
    }
}
