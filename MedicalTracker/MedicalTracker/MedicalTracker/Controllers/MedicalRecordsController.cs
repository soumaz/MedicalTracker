using System;
using MedicalTracker.Model;
using MedicalTracker.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalRecordsController : ControllerBase
    {
        private readonly ICrudMedicalRecordsRepo _medicalRecordsRepo;
        public MedicalRecordsController(ICrudMedicalRecordsRepo recordsRepo)
        {
            _medicalRecordsRepo = recordsRepo;
        }

        [HttpGet]
        [Route("medicines")]
        public ActionResult MedicinesInSystem()
        {
            try
            {
                var result = _medicalRecordsRepo.DisplayMedicines();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("medicineDetails")]
        public ActionResult MedicineDetails(int id)
        {
            try
            {
                var result =  _medicalRecordsRepo.DisplayMedicineDetails(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("medicines")]
        public ActionResult AddMedicines(MedicineAttributes medicine)
        {
            try
            {
                var result = _medicalRecordsRepo.AddMedicine(medicine);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("notes")]
        public ActionResult UpdateNotes(int id, string notes)
        {
            try
            {
                var result = _medicalRecordsRepo.UpdateNotes(id, notes);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [Route("error/404")]
        public IActionResult Error404()
        {
            return Ok("Custom Page Not Found");
        }
    }
}
