using My.Web.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace My.Web.Service
{
    public interface IPatientService
    {
        Task<Patient> GetPatientbyId(long PatientId);
        Task<IEnumerable<Patient>> GetPatientDetails();
    }
}
