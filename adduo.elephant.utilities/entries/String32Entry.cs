using entry_validarions = adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.utilities.entries
{
    public class String32Entry : StringEntry
    {
        public String32Entry()  
        {
            AddValidation(new entry_validarions.MaxLength(32));
        }
    }


}
