using System;

namespace Demo.FluentValidation
{
    public class ValidationRulesFields
    {
        public static bool ValidadeCreationDate(DateTime date)
        {
            return date != null && date >= DateTime.Now;
        }
    }
}
