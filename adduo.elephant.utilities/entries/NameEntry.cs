using entry_validarions = adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.utilities.entries
{
    public class NameEntry : String128Entry
    {
        public NameEntry()  
        {
            AddValidation(new entry_validarions.OnlyText());

        }
    }
}
