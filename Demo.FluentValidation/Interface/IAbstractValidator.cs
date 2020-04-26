using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.FluentValidation
{
    public interface IAbstractValidator<T>
    {
        IRuleBuilderInitial<T, TProperty> RuleFor<TProperty>(Expression<Func<T, TProperty>> expression);
        IRuleBuilderInitialCollection<T, TProperty> RuleForEach<TProperty>(Expression<Func<T, IEnumerable<TProperty>>> expression);
        void RuleSet(string ruleSetName, Action action);
        void AddRule(IValidationRule rule);
    }
}
