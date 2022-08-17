using CustomersClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CustomersTest
{
    public class AddressTest
    {
        AddressValidator addressValidator = new AddressValidator();
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
            Address address = new Address()
            {
                AddressLine1 = "",
                AddressLine2 = "qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq",
                AddressType = AddressTypes.Unknown,
                City = "",
                Country = "France",
                PostalCode = "",
                State = ""
                
            };
            List<string> results = new List<string>();

            results = addressValidator.Validate(address);

            Assert.Equal("Invalid first Address Line", results[0]);
            Assert.Equal("Invalid second Address Line", results[1]);
            Assert.Equal("Invalid Address Type", results[2]);
            Assert.Equal("Invalid City", results[3]);
            Assert.Equal("Invalid Country", results[4]);
            Assert.Equal("Invalid Postal Code", results[5]);
            Assert.Equal("Invalid State", results[6]);
        }
    }
}
