using FluentValidation;

namespace CustomersClassLibrary
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        ErrorMessages errorMessages = new ErrorMessages();
        public CustomerValidator()
        {
            RuleFor(c => c.FirstName).MaximumLength(50).WithMessage(errorMessages.FirsNameLenght);
            RuleFor(c => c.SecondName).NotEmpty().WithMessage(errorMessages.SecondNameLenght).MaximumLength(50).WithMessage(errorMessages.SecondNameNotEmpty);
            RuleFor(c => c.Addresses).NotEmpty().WithMessage(errorMessages.AddressesNotEmpty);
            RuleFor(c => c.PhoneNumber).Matches(@"^\+?[1-9]\d{1,14}$").WithMessage(errorMessages.InvaildPhoneFormat);
            RuleFor(c => c.CustomerEmail)
               .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage(errorMessages.InvalidEmailFormat);
            RuleFor(c => c.Notes)
               .NotEmpty().WithMessage(errorMessages.NotesNotEmpty);
        }
    }
}
