using adduo.elephant.utilities.validators;

namespace adduo.elephant.utilities.entries.entry_validators
{
    public class CPF : BaseEntryValidator<string>, IEntryValidation<string>
    {
        public void Validate()
        {
            if (CanValidate())
            {
                var test = CPFValidator.Check(entry.Value);
                SetInvalidStatus(test);
            }
        }
    }
}
