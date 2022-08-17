using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomersClassLibrary
{
    public class AddressValidator
    {
        private const int AddressLineMaxLength = 100;
        private const int CityMaxLength = 50;
        private const int PostalCodeMaxLength = 6;
        private const int StateMaxLength = 20;
        private static readonly List<string> AllowedCountries = new List<string>() { "United States", "Canada" };

        public List<string> Validate(Address address)
        {
            var errors = new List<string>();

            if (ValidateString(address.AddressLine1, AddressLineMaxLength))
            {
                errors.Add("Invalid first Address Line");
            }
            if (address.AddressLine2?.Length > AddressLineMaxLength)
            {
                errors.Add("Invalid second Address Line");
            }
            if (address.AddressType == AddressTypes.Unknown)
            {
                errors.Add("Invalid Address Type");
            }
            if (ValidateString(address.City, CityMaxLength))
            {
                errors.Add("Invalid City");
            }
            if (!AllowedCountries.Contains(address.Country, StringComparer.OrdinalIgnoreCase))
            {
                errors.Add("Invalid Country");
            }
            if (ValidateString(address.PostalCode, PostalCodeMaxLength))
            {
                errors.Add("Invalid Postal Code");
            }
            if (ValidateString(address.State, StateMaxLength))
            {
                errors.Add("Invalid State");
            }

            return errors;
        }

        private bool ValidateString(string input, int length)
        {
            return string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input) || input.Length > length;
        }
    }
}
