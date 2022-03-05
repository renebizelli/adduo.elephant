using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;
using System;

namespace adduo.elephant.domain.requests.debts.bundler_items
{
    public class RecurrentValueRequest : EntryClass
    {
        public DecimalEntry Amount { get; set; }
        public String64Entry Description { get; set; }

        public override void AddEntries()
        {
            AddEntry(Amount);
            AddEntry(Description);
        }

        public override void InitEntries()
        {
            Amount = new DecimalEntry();
            Description = new String64Entry();
        }

        public override void AddValidators()
        {
            Amount.AddValidation(new DecimalNotZero());
            Description.AddValidation(new StringNotEmpty());
        }
    }
}
