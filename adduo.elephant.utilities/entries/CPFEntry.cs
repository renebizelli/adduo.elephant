using adduo.elephant.utilities.extensionmethods;
using entry_validarions = adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.utilities.entries
{
    
    public class CPFEntry : Format
    {
        public CPFEntry() 
        {
            AddValidation(new entry_validarions.CPF());
        }

        public override string ToFormat()
        {
            return Value.CPFFormat();
        }
    }


}
