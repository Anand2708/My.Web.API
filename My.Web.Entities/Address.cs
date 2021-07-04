using System;
using System.Collections.Generic;
using System.Text;

namespace My.Web.Entities
{
    public class Address : EntityBase
    {
        public long AddressId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Zipcode { get; set; }
    }
}
