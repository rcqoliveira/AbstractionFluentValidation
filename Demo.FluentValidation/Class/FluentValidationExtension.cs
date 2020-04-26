using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Demo.FluentValidation
{
    public class FluentValidationExtension<T> : IAbstractValidator<T>
    {
        private AbstractValidator<T> AbstractValidator { get; set; }

        public void AddRule(IValidationRule rule)
        {
            AddRule(rule);
        }

        public IRuleBuilderInitial<T, TProperty> RuleFor<TProperty>(Expression<Func<T, TProperty>> expression)
        {
            return AbstractValidator.RuleFor(expression);
        }

        public IRuleBuilderInitialCollection<T, TProperty> RuleForEach<TProperty>(Expression<Func<T, IEnumerable<TProperty>>> expression)
        {
            return AbstractValidator.RuleForEach(expression);
        }

        public void RuleSet(string ruleSetName, Action action)
        {
            RuleSet(ruleSetName, action);
        }


    }
}
