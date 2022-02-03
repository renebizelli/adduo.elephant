using entry_validarions = adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.utilities.entries
{
    public class StringEntry : Entry<string>
    {
        public StringEntry()
        {
            AddValidations();
        }

        public bool IsNullOrEmpty()
        {
            return string.IsNullOrEmpty(this.Value);
        }

        public string ValueEmptyIfNull()
        {
            return string.IsNullOrEmpty(this.Value) ? string.Empty : this.Value;
        }


        private void AddValidations()
        {
            AddValidation(new entry_validarions.NotEmpty());
            AddValidation(new entry_validarions.SQLInjection());
        }
    }


}
