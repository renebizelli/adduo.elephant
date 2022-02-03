namespace adduo.elephant.utilities.entries.entry_validators
{
    public class IsADecimal : BaseEntryValidator<string>, IEntryValidation<string>
    {
        public virtual void Validate()
        {
            if (CanValidate())
            {
                decimal n = 0;
                var test = decimal.TryParse(entry.Value, out n);
                SetInvalidStatus(test);
            }
        }
    }
}
