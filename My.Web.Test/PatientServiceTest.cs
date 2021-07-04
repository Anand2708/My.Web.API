using Moq;
using My.Web.Service;
using System;
using My.Web.Entities;
using System.Collections.Generic;
using Xunit;
using My.Web.Repository;

namespace My.Web.Test
{
    public class PatientServiceTest
    {

        public Mock<IPatientRepository> mock = new Mock<IPatientRepository>();

        [Fact]
        public async void GetPatientbyId()
        {

            var patientDTO = new Patient()
            {
                KeyId = new Guid(),
                PatientId = 1,
                FirstName = "Abhishek",
                LastName = "Anand",
                Mobile = "888899998888",
                Gender ="Male",
                CreatedDate = DateTime.Now,
                Address = null
            };
            mock.Setup(p => p.GetPatientbyId(1)).ReturnsAsync(patientDTO);
            PatientService patientService = new PatientService(mock.Object);
            var result = await patientService.GetPatientbyId(1);
            Assert.Equal(patientDTO, result);
            Assert.Equal("Abhishek", result.FirstName);
        }

        [Fact]
        public async void GetPatientDetails()
        {

            var patientDTO = new Patient()
            {
                KeyId = new Guid(),
                PatientId = 1,
                FirstName = "Abhishek",
                LastName = "Anand",
                Mobile = "888899998888",
                Gender = "Male",
                CreatedDate = DateTime.Now,
                Address = null
            };
            List<Patient> patientList = new List<Patient>();
            patientList.Add(patientDTO);
            mock.Setup(p => p.GetPatientDetails()).ReturnsAsync(patientList);
            PatientService patientService = new PatientService(mock.Object);
            var result = await patientService.GetPatientDetails();
            Assert.True(patientList.Equals(result));
        }
    }
}
