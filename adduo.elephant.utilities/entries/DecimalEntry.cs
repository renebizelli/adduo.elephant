using System.Globalization;
using entry_validarions = adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.utilities.entries
{
    public class DecimalEntry : Entry<string>
    {
        public DecimalEntry()
        {
            AddValidation(new entry_validarions.IsADecimal());
        }

        public decimal GetValue()
        {
            decimal n = 0;

            decimal.TryParse(Value, NumberStyles.Number, CultureInfo.GetCultureInfo("en"), out n);

            return n;
        }

    }


}
