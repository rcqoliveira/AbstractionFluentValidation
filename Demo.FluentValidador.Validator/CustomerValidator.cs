
using Demo.FluentValidation;
using Demo.FluentValidation.Class;
using Demo.FluentValidationDomain;

namespace Demo.FluentValidador.Validator
{
    public class CustomerValidator : FluentValidationExtension<Company>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please specify a name");
            RuleFor(x => x.CreationDate).Must(ValidationRulesFields.ValidadeCreationDate).WithMessage("Invalid creation date");
        }
    }
}
