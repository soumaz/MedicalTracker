using MedicalTracker.Model;
using System.Collections.Generic;
using System.Linq;

namespace MedicalTracker.Repository
{
    public class CrudMedicalRecordsRepo : ICrudMedicalRecordsRepo
    {
        private readonly List<MedicineAttributes> _medicines;
        public CrudMedicalRecordsRepo()
        {
            _medicines = new List<MedicineAttributes>();
        }

        public List<MedicineAttributes> DisplayMedicines()
        {
            return _medicines.Select(x => new MedicineAttributes
            {
                Id = x.Id,
                Brand = x.Brand,
                ExpiryDate = x.ExpiryDate,
                FullName = x.FullName,
                Quantity = x.Quantity,
                Price = x.Price
            }).ToList();
        }

        public MedicineAttributes DisplayMedicineDetails(int id)
        {
            return _medicines.FirstOrDefault(x => x.Id == id);
        }

        public MedicineAttributes UpdateNotes(int id, string notes)
        {
            var medicine = _medicines.FirstOrDefault(x => x.Id == id);
            medicine.Notes = notes;
            return medicine;
        }

        public MedicineAttributes AddMedicine(MedicineAttributes medicine)
        {
            _medicines.Add(medicine);
            return medicine;
        }
    }
}
