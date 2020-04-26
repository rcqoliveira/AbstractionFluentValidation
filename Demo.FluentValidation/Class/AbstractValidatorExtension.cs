using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Demo.FluentValidation
{
    public abstract class AbstractValidatorExtension<T> : AbstractValidator<T>
    {
        public new abstract IRuleBuilderInitial<T, TProperty> RuleFor<TProperty>(Expression<Func<T, TProperty>> expression);
        public new abstract IRuleBuilderInitialCollection<T, TProperty> RuleForEach<TProperty>(Expression<Func<T, IEnumerable<TProperty>>> expression);
        public new abstract void RuleSet(string ruleSetName, Action action);
        public new abstract void AddRule(IValidationRule rule);
    }
}
