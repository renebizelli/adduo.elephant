using adduo.elephant.utilities.validators;

namespace adduo.elephant.utilities.entries.entry_validators
{
    public class Phone : BaseEntryValidator<string>, IEntryValidation<string>
    {
        public void Validate()
        {
            if (CanValidate())
            {
                var test = PhoneValidator.Check(entry.Value);
                SetInvalidStatus(test);
            }
        }
    }
}
