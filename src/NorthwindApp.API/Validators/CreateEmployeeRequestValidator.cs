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
            RuleFor(x => x.TitleOfCourtesy).MaximumLength(255);
            RuleFor(x => x.BirthDate).Null();
            RuleFor(x => x.HireDate).Null();
            RuleFor(x => x.Address).MaximumLength(255);
            RuleFor(x => x.City).MaximumLength(100);
            RuleFor(x => x.Region).MaximumLength(100);
            RuleFor(x => x.PostalCode).MaximumLength(100);
            RuleFor(x => x.Country).MaximumLength(100);
            RuleFor(x => x.HomePhone).MaximumLength(20);
            RuleFor(x => x.Extension).MaximumLength(20);
            RuleFor(x => x.Photo).Null();
            RuleFor(x => x.Notes).MaximumLength(500);
            RuleFor(x => x.ReportsTo).Null();
            RuleFor(x => x.PhotoPath).MaximumLength(255);
        }
    }
}
