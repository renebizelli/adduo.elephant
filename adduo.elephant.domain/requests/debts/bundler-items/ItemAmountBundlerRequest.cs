using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.domain.requests.debts.bundler_items
{
    public class ItemAmountBundlerRequest : ItemBundlerRequest
    {
        public DecimalEntry Amount { get; set; }

        public override void AddEntries()
        {
            base.AddEntries();

            AddEntry(Amount);
        }

        public override void InitEntries()
        {
            base.InitEntries();
            
            Amount = new DecimalEntry();
        }

        public override void AddValidators()
        {
            base.AddValidators();
            
            Amount.AddValidation(new DecimalNotZero());
        }
    }
}
