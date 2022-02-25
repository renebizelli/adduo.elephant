using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;
using System;

namespace adduo.elephant.domain.requests
{
    public abstract class DebtRequest : EntryClass
    {
        public Guid Id { get; set; }
        public NameEntry Name { get; set; }
        public IntEntry CategoryId { get; set; }

        public override void AddEntries()
        {
            AddEntry(Name);
            AddEntry(CategoryId);
        }

        public override void InitEntries()
        {
            Name = new NameEntry();
            CategoryId = new IntEntry();
        }

        public override void AddValidators()
        {
            CategoryId.AddValidation(new IntNotZero());
            Name.AddValidation(new StringNotEmpty());
        }

    }
}
