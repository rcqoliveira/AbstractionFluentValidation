using Demo.FluentValidation;
using Demo.FluentValidationDomain;

namespace Demo.FluentValidador.Validator
{
    public class EmployeeValidator : FluentValidationExtension<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please specify a name");
            RuleFor(x => x.BirthDate).Must(ValidationRulesFields.ValidBirthDate).WithMessage("Invalid creation date");
            RuleFor(x => x.AdmissionDate).Must(ValidationRulesFields.ValidCommonDate).WithMessage("Invalid creation date");
        }
    }
}
