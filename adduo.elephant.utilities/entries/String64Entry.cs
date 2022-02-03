using entry_validarions = adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.utilities.entries
{
    public class String64Entry : StringEntry
    {
        public String64Entry() 
        {
            AddValidation(new entry_validarions.MaxLength(64));
        }
    }


}
