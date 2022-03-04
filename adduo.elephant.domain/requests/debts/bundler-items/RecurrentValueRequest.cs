using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;
using System;

namespace adduo.elephant.domain.requests.debts.bundler_items
{
    public class RecurrentValueRequest : EntryClass
    {
        public Guid Id { get; set; }
        public DecimalEntry Value { get; set; }
        public String64Entry Description { get; set; }

        public override void AddEntries()
        {
            AddEntry(Value);
            AddEntry(Description);
        }

        public override void InitEntries()
        {
            Value = new DecimalEntry();
            Description = new String64Entry();
        }

        public override void AddValidators()
        {
            Value.AddValidation(new DecimalNotZero());
            Description.AddValidation(new StringNotEmpty());
        }
    }
}
