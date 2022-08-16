using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomersClassLibrary
{
    public class AddressValidator
    {
        public List<ValidationResult> AddressValidate(Address address)
        {

            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(address);
            Validator.TryValidateObject(address, validationContext, validationResults, true);
            return validationResults;
        }
    }
}
