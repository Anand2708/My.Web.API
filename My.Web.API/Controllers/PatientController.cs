using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using My.Web.LoggerService;
using My.Web.Entities;
using My.Web.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace My.Web.API.Controllers
{
    [ApiController]
    [Route("api/patient")]
   
    public class PatientController : ControllerBase
    {
        private readonly IPatientService patientService;
       // private readonly ILoggerManager logger;

        public PatientController(IPatientService patientService)
        {
            this.patientService = patientService;
            //this.logger = logger;
        }

        [HttpGet("GetPatientbyId/{PatientId}"), Authorize]
        public async Task<IActionResult> GetPatientbyId(long PatientId)
        {
            //logger.LogInfo("Fetching the Patient from the storage by PatientId");
            var result = await patientService.GetPatientbyId(PatientId);

            if (result == null) { return NotFound(); }
            return Ok(result);
        }

        [HttpGet("GetPatientDetails")]
        [Authorize]
        public async Task<ActionResult<Patient[]>> GetPatientDetails()
        {
            var result = await patientService.GetPatientDetails();
            // throw new Exception("Exception occured");
            //logger.LogInfo($"Returning {result.Count()} patient.");

            return Ok(result);
        }
    }
}
