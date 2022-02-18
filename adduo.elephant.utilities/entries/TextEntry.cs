using entry_validarions = adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.utilities.entries
{
    public class TextEntry : Entry<string>
    {
        public TextEntry()
        {
            AddValidation(new entry_validarions.StringNotEmpty());
        }
    }


}
