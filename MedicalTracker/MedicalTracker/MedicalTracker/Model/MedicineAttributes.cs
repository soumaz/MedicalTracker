using System;
namespace MedicalTracker.Model
{
    public class MedicineAttributes
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public string Brand { get; set; }

        public Decimal? Price { get; set; }

        public Decimal? Quantity { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string Notes { get; set; }
    }

}
