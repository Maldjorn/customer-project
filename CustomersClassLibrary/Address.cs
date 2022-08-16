using System;
using System.ComponentModel.DataAnnotations;

namespace CustomersClassLibrary
{
    public class Address
    {
        
        private string addressLine1;
        [Required]
        [StringLength(100)]
        public string AddressLine1
        {
            get
            {
                return addressLine1;
            }
            set
            {
                addressLine1 = value;
            }
        }
        
        private string addressLine2;
        [StringLength(100)]
        public string AddressLine2
        {
            get
            {
                return addressLine2;
            }
            set
            {
                addressLine2 = value;
            }
        }
        public enum addressType
        {
            Shipping,
            Billing
        }
        
        private string city;
        [Required]
        [StringLength(50)]
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        
        private string postalCode;
        [Required]
        [StringLength(6)]
        public string PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                postalCode = value;
            }
        }
        
        private string state;
        [Required]
        [StringLength(maximumLength: 20)]
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        private string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

    }
}
