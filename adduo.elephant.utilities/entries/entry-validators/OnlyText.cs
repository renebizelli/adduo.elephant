using adduo.elephant.utilities.validators;

namespace adduo.elephant.utilities.entries.entry_validators
{
    public class OnlyText : BaseEntryValidator<string>, IEntryValidation<string>
    {
        public void Validate()
        {
            if (CanValidate())
            {
                var test = StringValidator.Check(entry.Value);
                SetInvalidStatus(test);
            }
        }
    }
}
