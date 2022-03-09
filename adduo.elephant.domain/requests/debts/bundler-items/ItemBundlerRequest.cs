using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.domain.requests.debts.bundler_items
{
    public class ItemBundlerRequest : DebtRequest
    {
        public GuidEntry BundlerMonthly { get; set; }

        public override void AddEntries()
        {
            base.AddEntries();

            AddEntry(BundlerMonthly);
        }

        public override void InitEntries()
        {
            base.InitEntries();

            BundlerMonthly = new GuidEntry();
        }

        public override void AddValidators()
        {
            base.AddValidators();

            BundlerMonthly.AddValidation(new GuidNotEmpty());
        }
    }
}
