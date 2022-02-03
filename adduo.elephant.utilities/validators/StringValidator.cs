using System.Text.RegularExpressions;

namespace adduo.elephant.utilities.validators
{
    public class StringValidator
    {
        public static bool Check(string text)
        {
            var test = false;

            if (!string.IsNullOrEmpty(text))
            {
                string pattern = @"^[\p{L}\p{M}' \.\-]+$";

                var check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);

                test = check.IsMatch(text);
            }
            return test;
        }
    }
}
