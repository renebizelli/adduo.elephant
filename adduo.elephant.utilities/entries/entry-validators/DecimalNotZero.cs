
using adduo.elephant.utilities.extensionmethods;

namespace adduo.elephant.utilities.entries.entry_validators
{
    public class DecimalNotZero : IsADecimal
    {
        public override void Validate()
        {
            base.Validate();

            if (CanValidate())
            {
                var test = decimal.Parse(entry.Value).NotZero();

                SetEmptyStatus(test);
            }
        }
    }
}
