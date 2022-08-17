using System;
using System.ComponentModel.DataAnnotations;

namespace CustomersClassLibrary
{
    public class Address
    {
        
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public enum addressType { }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }        
        public string Country { get; set; }

    }
}
