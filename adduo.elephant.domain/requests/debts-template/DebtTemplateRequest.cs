using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;
using System;

namespace adduo.elephant.domain.requests.debts_template
{
    public abstract class DebtTemplateRequest : EntryClass
    {
        public Guid Id { get; set; }
        public NameEntry Name { get; set; }
        public IntEntry CategoryId { get; set; }
        public DayEntry DueDay { get; set; }
        public Guid BundlerTemplateId { get; set; }

        public override void AddEntries()
        {
            AddEntry(Name);
            AddEntry(CategoryId);
            AddEntry(DueDay);
        }

        public override void InitEntries()
        {
            Name = new NameEntry();
            CategoryId = new IntEntry();

            DueDay = new DayEntry();
        }

        public override void AddValidators()
        {
            CategoryId.AddValidation(new IntNotZero());
            Name.AddValidation(new StringNotEmpty());
        }

    }
}
