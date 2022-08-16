using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomersClassLibrary
{
    public class CustomerValidator
    {
        public List<ValidationResult> CustomerValidate(Customer customer)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(customer);
            bool isValid = Validator.TryValidateObject(customer, validationContext, validationResults, true);
            return validationResults;
        }
    }
}
