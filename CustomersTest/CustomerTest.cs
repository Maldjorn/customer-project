using CustomersClassLibrary;
using FluentValidation.TestHelper;
using System.Collections.Generic;
using Xunit;


namespace CustomersTest
{
    public class CustomerTest
    {
        CustomerValidator customerValidator = new CustomerValidator();
        [Fact]
        public void ShouldCreateCustomer()
        {
            Customer _customer = new Customer();
            _customer.FirstName = "John";
            _customer.SecondName = "Cena";
            _customer.PhoneNumber = "+14155554345";
            _customer.CustomerEmail = "name@example.com";
            _customer.Notes = new List<string>() { "Note1", "Note2" };
            _customer.TotalPurchaseAmount = 123;
            _customer.Addresses = new List<Address>() { new Address() { AddressLine1 = "1" }, new Address() { AddressLine1 = "2" } };
            Assert.Equal("John", _customer.FirstName);
            Assert.Equal("Cena", _customer.SecondName);
            Assert.Equal("+14155554345", _customer.PhoneNumber);
            Assert.Equal("name@example.com", _customer.CustomerEmail);
            Assert.Equal("Note1", _customer.Notes[0]);
            Assert.Equal(123, _customer.TotalPurchaseAmount);
            Assert.Equal(new Address() { AddressLine1 = "1" }.AddressLine1, _customer.Addresses[0].AddressLine1);
        }

        [Fact]
        public void ShouldHaveErrorWhenCreateCustomer()
        {
            Customer customer = new Customer()
            {
                FirstName = "fffffffffffffffffffffffffffffffffffffffffffffffffff",
                SecondName = "",
                Addresses = null,
                TotalPurchaseAmount = 0,
                Notes = new List<string>(),
                CustomerEmail = "exampleexample.com",
                PhoneNumber = "+1"
            };

            var result = customerValidator.TestValidate(customer);

            result.ShouldHaveValidationErrorFor(customer => customer.FirstName);
            result.ShouldHaveValidationErrorFor(customer => customer.SecondName);
            result.ShouldHaveValidationErrorFor(customer => customer.Addresses);
            result.ShouldHaveValidationErrorFor(customer => customer.Notes);
            result.ShouldHaveValidationErrorFor(customer => customer.CustomerEmail);
            result.ShouldHaveValidationErrorFor(customer => customer.PhoneNumber);
        }

    }
}
