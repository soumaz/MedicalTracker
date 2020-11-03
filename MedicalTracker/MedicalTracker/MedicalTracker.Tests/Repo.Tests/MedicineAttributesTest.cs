using MedicalTracker.Model;
using MedicalTracker.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MedicalTracker.Tests.Repo.Tests
{
    public class MedicineAttributesTest
    {
        private readonly CrudMedicalRecordsRepo _repo;
        public MedicineAttributesTest()
        {
            _repo = new CrudMedicalRecordsRepo();
        }

        [Fact]
        public void AddMedicines()
        {
            var request = new MedicineAttributes()
            {
                Id = 1,
                Brand = "Glaxo",
                ExpiryDate = DateTime.Parse("11/3/21018"),
                FullName = "Paracetamol",
                Price = 20,
                Quantity = 10,
                Notes = "Test"
            };
            var result = _repo.AddMedicine(request);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void FetchAllMedicines()
        {
            var result = _repo.DisplayMedicines();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void FetchMedicines()
        {
            int id = 1;
            var result = _repo.DisplayMedicineDetails(id);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void UpdateNotyes()
        {
            int id = 1;
            string note = "Test";
            var result = _repo.UpdateNotes(id,note);
            Assert.IsType<OkObjectResult>(result);
        }

    }
}
