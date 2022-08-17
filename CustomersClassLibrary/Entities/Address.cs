using System;
using System.ComponentModel.DataAnnotations;

namespace CustomersClassLibrary
{
    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public AddressTypes AddressType { get; set; } = AddressTypes.Unknown; 
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

    }

    public enum AddressTypes
    {
        Unknown,
        Shipping,
        Billing
    }
}
