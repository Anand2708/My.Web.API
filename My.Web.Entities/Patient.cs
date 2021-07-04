using System;
using System.Collections.Generic;
using System.Text;

namespace My.Web.Entities
{
    public class Patient : EntityBase
    {
        public long PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public Address Address { get; set; }
    }
}
