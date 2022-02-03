using adduo.elephant.utilities.extensionmethods;

namespace adduo.elephant.utilities.entries.entry_validators
{
    public class SQLInjection : BaseEntryValidator<string>, IEntryValidation<string>
    {
        public void Validate()
        {
            if (CanValidate())
            {
                var test = !entry.Value.SQLInjection();

                SetInvalidStatus(test);
            }
        }
    }
}
