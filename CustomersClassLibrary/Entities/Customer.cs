using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomersClassLibrary
{
    public class Customer : Person
    {
        public List<Address> Addresses { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<string> Notes { get; set; }

        public decimal? TotalPurchasesAmount { get; set; }
    }
}
