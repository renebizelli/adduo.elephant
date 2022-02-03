using adduo.elephant.utilities.validators;

namespace adduo.elephant.utilities.entries.entry_validators
{
    public class Email : BaseEntryValidator<string>, IEntryValidation<string>
    {
        public void Validate()
        {
            if (CanValidate())
            {
                var test = EmailValidator.Check(entry.Value);
                SetInvalidStatus(test);
            }
        }
    }
}
