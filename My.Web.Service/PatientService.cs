using My.Web.Entities;
using My.Web.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace My.Web.Service
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            this.patientRepository = patientRepository;
        }
        public async Task<Patient> GetPatientbyId(int? PatientId)
        {
            if (PatientId == null) { throw new Exception("Patient Id is null"); }

            if (PatientId <= 0) { throw new Exception("Invalid Patient Id"); }

            var result = await patientRepository.GetPatientbyId(PatientId);
            return result;
        }

        public async Task<IEnumerable<Patient>> GetPatientDetails()
        {
            var result = await patientRepository.GetPatientDetails();
            return result;
        }


    }
}
