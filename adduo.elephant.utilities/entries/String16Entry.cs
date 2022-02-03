using entry_validarions = adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.utilities.entries
{
    public class String16Entry : StringEntry
    {
        public String16Entry() 
        {
            AddValidation(new entry_validarions.MaxLength(16));
        }
    }


}
