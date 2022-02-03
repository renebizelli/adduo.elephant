﻿using System.Text.RegularExpressions;

namespace adduo.elephant.utilities.validators
{
    public class EmailValidator
    {
        public static bool Check(string email)
        {
            var test = false;

            if (!string.IsNullOrEmpty(email))
            {
                string pattern = @"^[_a-zA-Z0-9-]+(\.[_a-zA-Z0-9-]+)*@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.(com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$";

                var check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);

                test = check.IsMatch(email);
            }
            return test;
        }
    }
}
