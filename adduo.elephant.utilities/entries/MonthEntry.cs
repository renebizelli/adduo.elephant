using entry_validarions = adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.utilities.entries
{
    public class MonthEntry : IntEntry
    {
        public MonthEntry()
        {
            AddValidation(new entry_validarions.IntNotZero());
            AddValidation(new entry_validarions.IsAMonth());
        }
    }


}
