using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.domain.requests.debts.bundler_items
{
    public class ItemRequest : DebtRequest
    {
        public DecimalEntry Value { get; set; }

        public GuidEntry BundlerMonthly { get; set; }

        public override void AddEntries()
        {
            base.AddEntries();

            AddEntry(Value);
            AddEntry(BundlerMonthly);
        }

        public override void InitEntries()
        {
            base.InitEntries();

            Value = new DecimalEntry();
            BundlerMonthly = new GuidEntry();
        }

        public override void AddValidators()
        {
            base.AddValidators();

            Value.AddValidation(new DecimalNotZero());
            BundlerMonthly.AddValidation(new GuidNotEmpty());
        }
    }
}
