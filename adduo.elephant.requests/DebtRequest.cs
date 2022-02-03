using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;
using System;

namespace adduo.elephant.requests
{
    public abstract class DebtRequest : EntryClass
    {
        public DecimalEntry Value { get; set; }
        public IntEntry CategoryId { get; set; }

        public override void AddEntries()
        {
            AddEntry(Value);
            AddEntry(CategoryId);
        }

        public override void InitEntries()
        {
            Value = new DecimalEntry();
            CategoryId = new IntEntry();
        }

        public override void AddValidators()
        {
            CategoryId.AddValidation(new IntNotZero());
            Value.AddValidation(new DecimalNotZero());
        }
    }
}
