using System.Text.RegularExpressions;

namespace adduo.elephant.utilities.validators
{
    public class PhoneValidator
    {
        public static bool Check(string phone)
        {
            var result = false;

            var _test = Regex.Replace(phone, "[\\-/()_+ ]", string.Empty);

            var check = new Regex("[^0-9]", RegexOptions.IgnorePatternWhitespace);

            if (!check.IsMatch(_test))
            {
                result = _test.Length >= 9;
            }

            return result;
        }
    }
}
