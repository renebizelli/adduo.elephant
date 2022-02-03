using adduo.elephant.utilities.extensionmethods;
using entry_validarions = adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.utilities.entries
{
    public class PhoneEntry : Format
    {
        public PhoneEntry() 
        {
            AddValidation(new entry_validarions.Phone());
        }

        public string OnlyNumbers()
        {
            return Value.OnlyNumbers();
        }

        public override string ToFormat()
        {
            return this.PhoneFormat();
        }
    }


}
