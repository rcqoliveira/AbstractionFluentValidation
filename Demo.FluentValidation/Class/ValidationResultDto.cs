using System.Collections.Generic;
using System.Linq;

namespace Demo.FluentValidation.Class
{
    public class ValidationResultDto
    {
        public ValidationResultDto(IEnumerable<string> errors)
        {
            Errors = errors;
        }

        private ValidationResultDto()
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

        public static ValidationResultDto Build(IEnumerable<string> errors)
        {
            return new ValidationResultDto(errors);
        }


    }
}
