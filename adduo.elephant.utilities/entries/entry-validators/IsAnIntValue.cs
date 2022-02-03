namespace adduo.elephant.utilities.entries.entry_validators
{
    public class IsAnInt : BaseEntryValidator<string>, IEntryValidation<string>
    {
        public virtual void Validate()
        {
            if (CanValidate())
            {
                var n = 0;
                var test = int.TryParse(entry.Value, out  n);
                SetInvalidStatus(test);
            }
        }
    }
}
