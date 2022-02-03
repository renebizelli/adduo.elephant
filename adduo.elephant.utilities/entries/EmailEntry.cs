using entry_validarions = adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.utilities.entries
{
    public class EmailEntry : String128Entry
    {
        public EmailEntry()  
        {
            AddValidation(new entry_validarions.Email());

        }
    }


}
