using CustomersClassLibrary;
using System.Collections.Generic;
using Xunit;


namespace CustomersTest
{
    public class CustomerTest
    {
        CustomerValidator customerValidator = new CustomerValidator();

        [Fact]
        public void ShouldCreateCustomerWithArg()
        {
            Customer _customer = new Customer();
            _customer.FirstName = "John";
            _customer.SecondName = "Cena";
            _customer.PhoneNumber = "+14155554345";
            _customer.Email = "name@example.com";
            _customer.Notes = new List<string>() { "Note1", "Note2" };
            _customer.TotalPurchasesAmount = 123;
            _customer.Addresses = new List<Address>() { new Address() { AddressLine1 = "1" }, new Address() { AddressLine1 = "2" } };
            Assert.Equal("John", _customer.FirstName);
            Assert.Equal("Cena", _customer.SecondName);
            Assert.Equal("+14155554345", _customer.PhoneNumber);
            Assert.Equal("name@example.com", _customer.Email);
            Assert.Equal("Note1", _customer.Notes[0]);
            Assert.Equal(123, _customer.TotalPurchasesAmount);
            Assert.Equal(new Address() { AddressLine1 = "1" }.AddressLine1, _customer.Addresses[0].AddressLine1);
        }

        [Fact]
        public void IsValidTests()
        {
            Customer customer = new Customer()
            {
                FirstName = "qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq",
                SecondName = "",
                Addresses = new List<Address>(),
                Email = "qweqwecom",
                Notes = new List<string>(),
                PhoneNumber = "1",
                TotalPurchasesAmount = -1
            };

            List<string> results = new List<string>();

            results = customerValidator.Validate(customer);

            Assert.Equal("Invalid First Name", results[0]);
            Assert.Equal("Invalid Second Name", results[1]);
            Assert.Equal("Invalid Addresses", results[2]);
            Assert.Equal("Invalid Phone Number", results[3]);
            Assert.Equal("Invalid Email", results[4]);
            Assert.Equal("Invalid Notes Count", results[5]);
            Assert.Equal("Invalid Total Purchases Amount", results[6]);
        }

    }
}
