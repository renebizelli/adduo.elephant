using adduo.elephant.utilities.extensionmethods;

namespace adduo.elephant.utilities.entries.entry_validators
{
    public class Password : BaseEntryValidator<string>, IEntryValidation<string>
    {
        public void Validate()
        {
            if (CanValidate())
            {
                var entryPassword = (entries.PasswordEntry)entry;
                var test = entryPassword.Value.NotIsNullOrEmpty();
                SetEmptyStatus(test);
            }
        }
    }
}
