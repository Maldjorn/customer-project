using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CustomersClassLibrary
{
    public class CustomerValidator
    {
        private const int FirstNameMaxLength = 50;
        private const int SecondNameMaxLength = 50;
        private const int AddressesMinCount = 1;
        private const int NotesMinCount = 1;
        private readonly Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        private readonly Regex PhoneRegex = new Regex(@"^\+?[1-9]\d{1,14}$");

        public List<string> Validate(Customer customer)
        {
            var validationErrors = new List<string>();

            if (customer.FirstName.Length > FirstNameMaxLength)
            {
                validationErrors.Add("Invalid First Name");
            }
            if (string.IsNullOrWhiteSpace(customer.SecondName) || customer.SecondName.Length > SecondNameMaxLength)
            {
                validationErrors.Add("Invalid Second Name");
            }
            if (customer.Addresses?.Count < AddressesMinCount)
            {
                validationErrors.Add("Invalid Addresses");
            }
            if (!PhoneRegex.IsMatch(customer.PhoneNumber))
            {
                validationErrors.Add("Invalid Phone Number");
            }
            if (!EmailRegex.IsMatch(customer.Email))
            {
                validationErrors.Add("Invalid Email");
            }
            if (customer.Notes?.Count < NotesMinCount)
            {
                validationErrors.Add("Invalid Notes Count");
            }
            if (customer.TotalPurchasesAmount < 0)
            {
                validationErrors.Add("Invalid Total Purchases Amount");
            }

            return validationErrors;
        }
    }
}
