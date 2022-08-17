using CustomersClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;


namespace CustomersTest
{
    public class CustomerTest
    {
        [Fact]
        public void ShouldCreateCustomerWithArg()
        {
            Customer _customer = new Customer() ;
            _customer.FirstName = "John";
            _customer.SecondName = "Cena";
            _customer.PhoneNumber = "+14155554345";
            _customer.CustomerEmail = "name@example.com";
            _customer.Notes = new List<string>() { "Note1", "Note2" };
            _customer.TotalPurchaseAmount = 123;
            _customer.Addresses = new List<Address>() { new Address() { AddressLine1 = "1"}, new Address() {AddressLine1 = "2" } };
            Assert.Equal("John", _customer.FirstName);
            Assert.Equal("Cena", _customer.SecondName);
            Assert.Equal("+14155554345", _customer.PhoneNumber);
            Assert.Equal("name@example.com", _customer.CustomerEmail);
            Assert.Equal("Note1", _customer.Notes[0]);
            Assert.Equal(123, _customer.TotalPurchaseAmount);
            Assert.Equal(new Address() { AddressLine1 = "1"}.AddressLine1, _customer.Addresses[0].AddressLine1);
        }

        [Fact]
        public void IsValidTests()
        {
            Customer customer = new Customer() { FirstName = "" };
            CustomerValidator customerValidator = new CustomerValidator();
            var result = customerValidator.CustomerValidate(customer);

            Assert.Equal("The Notes field is required.",result[0].ErrorMessage);

        }

    }
}
