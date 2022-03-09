using adduo.elephant.utilities.entries;

namespace adduo.elephant.domain.requests.debts.bundler_items
{
    public class YearlyBundlerRequest : ItemAmountBundlerRequest
    {
        public MonthEntry DueMonth { get; set; }

        public override void AddEntries()
        {
            base.AddEntries();

            AddEntry(DueMonth);
        }

        public override void InitEntries()
        {
            base.InitEntries();

            DueMonth = new MonthEntry();
        }
    }
}
