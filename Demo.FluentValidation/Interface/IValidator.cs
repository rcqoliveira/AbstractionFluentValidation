using Demo.FluentValidation.Class;
using System.Collections.Generic;

namespace Demo.FluentValidation.Interface
{
    public interface IValidator<T>
    {
        bool IsValid { get; }
        ValidationResult Validate(T instance);
        IEnumerable<string> GetError();
    }
}
