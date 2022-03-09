using adduo.elephant.utilities.entries;
using adduo.elephant.utilities.entries.entry_validators;

namespace adduo.elephant.domain.requests.debts.bundler_items
{
    public class RecurrentBundlerSaveRequest : RecurrentBundlerRequest
    {
        public String64Entry Description { get; set; }
        public DecimalEntry Value { get; set; }

        public override void AddEntries()
        {
            base.AddEntries();

            AddEntry(Value);
            AddEntry(Description);
        }

        public override void InitEntries()
        {
            base.InitEntries();

            Value = new DecimalEntry();
            Description = new String64Entry();
        }

        public override void AddValidators()
        {
            base.AddValidators();

            Value.AddValidation(new DecimalNotZero());
            Description.AddValidation(new StringNotEmpty());
        }
    }
}
