using adduo.elephant.utilities.extensionmethods;

namespace adduo.elephant.utilities.entries.entry_validators
{
    public class StringNotEmpty : BaseEntryValidator<string>, IEntryValidation<string>
    {
        public void Validate()
        {
            if (CanValidate())
            {
                var test = entry.Value.NotIsNullOrEmpty();

                SetEmptyStatus(test);
            }
        }
    }
}
