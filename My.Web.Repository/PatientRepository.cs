using Microsoft.EntityFrameworkCore;
using My.Web.Data;
using My.Web.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace My.Web.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly PatientDbContext patientDbContext;

        public PatientRepository(PatientDbContext patientDbContext)
        {
            this.patientDbContext = patientDbContext;
        }
        public async Task<Patient> GetPatientbyId(long PatientId)
        {
            var result = await patientDbContext.Patients.SingleOrDefaultAsync(p => p.PatientId == PatientId);
            return result;
        }

        public async Task<IEnumerable<Patient>> GetPatientDetails()
        {
            var PatientDetails = await patientDbContext.Patients
                                .Include(p => p.Address)
                                .ToListAsync();
            return PatientDetails;
        }

        public async Task<bool> SaveChangesAsync()
        {
            if (await patientDbContext.SaveChangesAsync() > 0)
                return true;
            else
                return false;
        }
    }
}
