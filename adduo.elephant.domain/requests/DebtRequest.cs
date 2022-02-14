using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;
using System;

namespace adduo.elephant.domain.requests
{
    public abstract class DebtRequest : EntryClass
    {
        public Guid Id { get; set; }
        public NameEntry Name { get; set; }
        public DecimalEntry Value { get; set; }
        public ListEntry<int> Tags { get; set; }

        public override void AddEntries()
        {
            AddEntry(Name);
            AddEntry(Value);
            AddEntry(Tags);
        }

        public override void InitEntries()
        {
            Name = new NameEntry();
            Value = new DecimalEntry();
            Tags = new ListEntry<int>();
        }

        public override void AddValidators()
        {
            Tags.AddValidation(new NotEmptyList<int>());
            Value.AddValidation(new DecimalNotZero());
        }
    }
}
