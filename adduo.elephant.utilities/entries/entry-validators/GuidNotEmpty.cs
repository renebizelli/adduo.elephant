using adduo.elephant.utilities.extensionmethods;
using System;

namespace adduo.elephant.utilities.entries.entry_validators
{
    public class GuidNotEmpty : BaseEntryValidator<string>, IEntryValidation<string>
    {
        public void Validate()
        {
            if (CanValidate())
            {
                var guid = Guid.Empty;

                Guid.TryParse(entry.Value, out guid);

                var test = guid.NotIsEmpty();

                SetEmptyStatus(test);
            }
        }
    }
}
