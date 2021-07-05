using My.Web.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace My.Web.Repository
{
    public interface IPatientRepository
    {
        Task<Patient> GetPatientbyId(long PatientId);
        Task<IEnumerable<Patient>> GetPatientDetails();

        Task<bool> SaveChangesAsync();
    }
}
