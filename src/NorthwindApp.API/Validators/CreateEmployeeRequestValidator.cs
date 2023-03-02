using FluentValidation;
using NorthwindApp.API.Models;

namespace NorthwindApp.API.Validators
{
    public class CreateEmployeeRequestValidator : AbstractValidator<CreateEmloyeeRequest>
    {
        public CreateEmployeeRequestValidator()
        {
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.LastName).MaximumLength(20);
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.FirstName).MaximumLength(50);
            RuleFor(x => x.Title).MaximumLength(255);
            RuleFor(x => x.BirthDate).Null();
            RuleFor(x => x.HireDate).Null();
            RuleFor(x => x.Address).MaximumLength(255);
            RuleFor(x => x.Region).MaximumLength(50);
            RuleFor(x => x.PostalCode).MaximumLength(50);
            RuleFor(x => x.Country).MaximumLength(20);
            RuleFor(x => x.HomePhone).MaximumLength(20);
            RuleFor(x => x.Notes).MaximumLength(255);
        }
    }
}
