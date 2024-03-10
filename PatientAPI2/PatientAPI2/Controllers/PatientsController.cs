using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatientAPI2.Data;
using PatientAPI2.Models;

namespace PatientAPI2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : Controller
    {
        private readonly PatientsAPIDbContext dbContext;

        public PatientsController(PatientsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetPatients()
        {

            return Ok(await dbContext.Patients.ToListAsync());
            
        }

        [HttpGet]
        [Route("{patientID:guid}")]
        public async Task<IActionResult> GetPatient([FromRoute] Guid patientID)
        {
            var patient = await dbContext.Patients.FindAsync(patientID);

            if(patient == null) 
            {
                return NotFound();
            }

            return Ok(patient);
        }

        [HttpPost]
        public async Task<IActionResult> AddPatients(AddPatientRequest addPatientRequest)
        {
            var patient = new Patient()
            {
                PatientID = Guid.NewGuid(),
                PatientName = addPatientRequest.PatientName,
                DiseaseInformation = addPatientRequest.DiseaseInformation,
                Epilepsy = addPatientRequest.Epilepsy

            };

            await dbContext.Patients.AddAsync(patient);    
            await dbContext.SaveChangesAsync();    

            return Ok(patient);
        }

        [HttpPut]
        [Route("{patientID:guid}")]
        public async Task<IActionResult> UpdatePatient([FromRoute] Guid patientID, UpdatePatientRequest updatePatientRequest)
        {
            var patient = await dbContext.Patients.FindAsync(patientID);

            if(patient != null) 
            { 
                patient.PatientName = updatePatientRequest.PatientName;
                patient.DiseaseInformation = updatePatientRequest.DiseaseInformation;   
                patient.Epilepsy = updatePatientRequest.Epilepsy;  
                
                await dbContext.SaveChangesAsync();

                return Ok(patient);
            }

            return NotFound();
        }

        [HttpDelete]
        [Route("{patientID:guid}")]
        public async Task<IActionResult> DeletePatient([FromRoute] Guid patientID)
        {
            var patient = await dbContext.Patients.FindAsync(patientID);

            if (patient != null)
            {
                dbContext.Remove(patient);
                await dbContext.SaveChangesAsync();
                return Ok(patient);
            }

            return NotFound();
        }
    }
}
