using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomersClassLibrary
{
    public class Customer : Person
    {
        private List<Address> adresses;
        public List<Address> Adresses
        {
            get
            {
                return adresses;
            }
            set
            {
                adresses = value;
            }
        }
        [RegularExpression(@"^\+?[1-9]\d{1,14}$", ErrorMessage = "Invalid phone number")]
        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Invalid Email")]
        private string customerEmail;
        public string CustomerEmail
        {
            get
            {
                return customerEmail;
            }
            set
            {
                customerEmail = value;
            }
        }
        private List<string> notes;
        [Required]
        public List<string> Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }
        private decimal? totalPurchaseAmount;
        public decimal? TotalPurchaseAmount
        {
            get
            {
                return totalPurchaseAmount;
            }
            set
            {
                if (value != null)
                {
                    totalPurchaseAmount = value;
                }
            }
        }

        public Customer() : base()
        {

        }
    }
}
