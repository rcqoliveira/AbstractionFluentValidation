using Demo.FluentValidation.Class;
using FluentValidation;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace Demo.FluentValidation
{
    public abstract class Validator<T> : AbstractValidator<T>, Interface.IValidator<T>
    {
        private global::FluentValidation.Results.ValidationResult ValidationResult;

        public bool IsValid
        {
            get
            {
                return ValidationResult != null && ValidationResult.IsValid;
            }
        }

        public IEnumerable<string> GetError()
        {
            return ValidationResult.Errors.Select(x => x.ErrorMessage);
        }

        private void BuildValidate(T instance)
        {
            ValidationResult = base.Validate(instance);
        }

        public new Class.ValidationResult Validate(T instance)
        {
            BuildValidate(instance);
            return Class.ValidationResult.Build(GetError());
        }

        

    }
}
