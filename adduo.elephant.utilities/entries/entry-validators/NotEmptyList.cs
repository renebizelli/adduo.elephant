using System.Collections.Generic;

namespace adduo.elephant.utilities.entries.entry_validators
{
    public class NotEmptyList<T> : BaseEntryValidator<List<T>>, IEntryValidation<List<T>>
    {
        public void Validate()
        {
            if (CanValidate())
            {
                var test = entry.Value != null && entry.Value.Count > 0;
                SetEmptyStatus(test);
            }
        }
    }
}
