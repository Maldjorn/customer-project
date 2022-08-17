using CustomersClassLibrary;
using FluentValidation;
using FluentValidation.TestHelper;
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
        public void ShouldHaveErrorWhenCreateAddress()
        {
            Address address = new Address()
            {
                AddressLine1 = "",
                AddressLine2 = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                City = "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee",
                PostalCode = "2222222221",
                State = "",
                Country = "N"      
            };
            var result = addressValidator.TestValidate(address);
            result.ShouldHaveValidationErrorFor(address => address.AddressLine1);
            result.ShouldHaveValidationErrorFor(address => address.AddressLine2);
            result.ShouldHaveValidationErrorFor(address => address.City);
            result.ShouldHaveValidationErrorFor(address => address.PostalCode);
            result.ShouldHaveValidationErrorFor(address => address.State);
            result.ShouldHaveValidationErrorFor(address => address.Country);
        }
    }
}
