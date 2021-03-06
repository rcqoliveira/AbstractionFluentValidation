﻿using System;

namespace Demo.FluentValidation
{
    public class ValidationRulesFields
    {
        public static bool ValidCommonDate(DateTime date)
        {
            return date != null && date >= DateTime.Today;
        }

        public static bool ValidBirthDate(DateTime date)
        {
            return date != null && date < DateTime.Now;
        }
    }
}
