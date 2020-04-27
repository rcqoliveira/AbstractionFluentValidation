using System.Collections.Generic;
using System.Linq;

namespace Demo.FluentValidation.Class
{
    public class ValidationResult
    {
        public ValidationResult(IEnumerable<string> errors)
        {
            Errors = errors;
        }

        private ValidationResult()
        {

        }

        public IEnumerable<string> Errors { get; private set; }

        public bool IsValid
        {
            get
            {
                return Errors.Count() != 0;
            }
        }

        public static ValidationResult Build(IEnumerable<string> errors)
        {
            return new ValidationResult(errors);
        }


    }
}
