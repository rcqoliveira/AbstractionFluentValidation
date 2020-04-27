using Demo.FluentValidationDomain;
using FluentValidation;

namespace Demo.FluentValidation
{
    public class EmployeeValidator : Validator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please specify a name");
            RuleFor(x => x.BirthDate).Must(ValidationRulesFields.ValidBirthDate).WithMessage("Invalid creation date");
            RuleFor(x => x.AdmissionDate).Must(ValidationRulesFields.ValidCommonDate).WithMessage("Invalid creation date");
        }
    }
}
