using MedicalTracker.Model;
using System.Collections.Generic;
namespace MedicalTracker.Repository
{
    public interface ICrudMedicalRecordsRepo
    {
        List<MedicineAttributes> DisplayMedicines();

        MedicineAttributes DisplayMedicineDetails(int id);

        MedicineAttributes AddMedicine(MedicineAttributes medicine);

        MedicineAttributes UpdateNotes(int id, string notes);
    }
}
