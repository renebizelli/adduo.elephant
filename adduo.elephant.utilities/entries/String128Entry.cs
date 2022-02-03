using entry_validarions = adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.utilities.entries
{
    public class String128Entry : StringEntry
    {
        public String128Entry()  
        {
            AddValidation(new entry_validarions.MaxLength(128));
        }
    }


}
