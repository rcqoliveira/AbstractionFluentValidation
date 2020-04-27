using Demo.FluentValidation;
using Demo.FluentValidationDomain;

namespace Demo.FluentValidador.Validator
{
    public class CompanyValidator : FluentValidationExtension<Company>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please specify a name");
            RuleFor(x => x.CreationDate).Must(ValidationRulesFields.ValidCommonDate).WithMessage("Invalid creation date");
        }
    }
}
