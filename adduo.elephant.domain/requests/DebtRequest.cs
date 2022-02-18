using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;
using System;

namespace adduo.elephant.domain.requests
{
    public abstract class DebtRequest : EntryClass
    {
        public Guid Id { get; set; }
        public NameEntry Name { get; set; }
        public ListEntry<int> Tags { get; set; }

        public override void AddEntries()
        {
            AddEntry(Name);
            AddEntry(Tags);
        }

        public override void InitEntries()
        {
            Name = new NameEntry();
            Tags = new ListEntry<int>();
        }

        public override void AddValidators()
        {
            Tags.AddValidation(new NotEmptyList<int>());
            Name.AddValidation(new StringNotEmpty());
        }

    }
}
