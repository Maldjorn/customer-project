using System;
using CustomersClassLibrary;

namespace Customers
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { FirstName = "", PhoneNumber = "-" };
            CustomerValidator customerValidator = new CustomerValidator();
            customerValidator.CustomerValidate(customer);
        }
    }
}
