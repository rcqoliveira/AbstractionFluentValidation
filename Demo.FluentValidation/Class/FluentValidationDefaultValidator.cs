using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections;
using System.Linq.Expressions;

namespace Demo.FluentValidation.Class
{
    public static class FluentValidationDefaultValidator
    {
        public static IRuleBuilderOptions<T, TProperty> NotEmpty<T, TProperty>(this IRuleBuilder<T, TProperty> ruleBuilder)
        {
            return DefaultValidatorExtensions.NotEmpty(ruleBuilder);
        }

        public static IRuleBuilderOptions<T, TProperty> WithMessage<T, TProperty>(this IRuleBuilderOptions<T, TProperty> rule, string errorMessage)
        {
            return DefaultValidatorExtensions.NotEmpty(rule).WithMessage(errorMessage);
        }

        public static IRuleBuilderOptions<T, string> Length<T>(this IRuleBuilder<T, string> ruleBuilder, int min, int max)
        {
            return DefaultValidatorExtensions.Length(ruleBuilder, min, max);
        }

        public static IRuleBuilderOptions<T, string> Length<T>(this IRuleBuilder<T, string> ruleBuilder, int exactLength)
        {
            return DefaultValidatorExtensions.Length(ruleBuilder, exactLength);
        }

        public static IRuleBuilderOptions<T, TProperty> Must<T, TProperty>(this IRuleBuilder<T, TProperty> ruleBuilder, Func<T, TProperty, PropertyValidatorContext, bool> predicate)
        {
            return DefaultValidatorExtensions.Must(ruleBuilder, predicate);
        }

        public static IRuleBuilderOptions<T, TProperty> Must<T, TProperty>(this IRuleBuilder<T, TProperty> ruleBuilder, Func<TProperty, bool> predicate)
        {
            return DefaultValidatorExtensions.Must(ruleBuilder, predicate);
        }

        public static IRuleBuilderOptions<T, TProperty> Must<T, TProperty>(this IRuleBuilder<T, TProperty> ruleBuilder, Func<T, TProperty, bool> predicate)
        {
            return DefaultValidatorExtensions.Must(ruleBuilder, predicate);
        }

        public static IRuleBuilderOptions<T, TProperty> NotEqual<T, TProperty>(this IRuleBuilder<T, TProperty> ruleBuilder, Expression<Func<T, TProperty>> expression, IEqualityComparer comparer = null)
        {
            return DefaultValidatorExtensions.NotEqual(ruleBuilder, expression, comparer);
        }
    
        public static IRuleBuilderOptions<T, TProperty> NotEqual<T, TProperty>(this IRuleBuilder<T, TProperty> ruleBuilder, TProperty toCompare, IEqualityComparer comparer = null)
        {
            return DefaultValidatorExtensions.NotEqual(ruleBuilder, toCompare, comparer);
        }

        public static IRuleBuilderOptions<T, TProperty> NotNull<T, TProperty>(this IRuleBuilder<T, TProperty> ruleBuilder)
        {
            return DefaultValidatorExtensions.NotNull(ruleBuilder);
        }
    }
}


