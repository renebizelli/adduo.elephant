using entry_validarions = adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.utilities.entries
{
    public class DayEntry : IntEntry
    {
        public DayEntry()
        {
            AddValidation(new entry_validarions.IsADay());
        }
    }


}
