using CustomersClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CustomersTest
{
    public class AddressTest
    {
        [Fact]
        public void ShouldCreateAddressWithArgs()
        {
            Address address = new Address();
            address.AddressLine1 = "Some address";
            address.AddressLine2 = "Some address2";
            address.City = "Some city";
            address.State = "Some state";
            address.PostalCode = "12332";
            address.Country = "Some Country";
            Assert.Equal("Some address", address.AddressLine1);
            Assert.Equal("Some address2", address.AddressLine2);
            Assert.Equal("Some city", address.City);
            Assert.Equal("Some state", address.State);
            Assert.Equal("12332", address.PostalCode);
            Assert.Equal("Some Country", address.Country);
        }

        [Fact]
        public void ShouldDoAddressValidation()
        {
            Address address = new Address() { AddressLine1 = "" };
            AddressValidator addressValidator = new AddressValidator();
            var result = addressValidator.AddressValidate(address);

            Assert.Equal("The AddressLine1 field is required.", result[0].ErrorMessage);
        }
    }
}
