using adduo.elephant.utilities.extensionmethods;

namespace adduo.elephant.utilities.entries.entry_validators
{
    public class IntNotZero : IsAnInt
    {
        public override void Validate()
        {
            base.Validate();

            if (CanValidate())
            {
                var test = int.Parse(entry.Value).NotZero();

                SetEmptyStatus(test);
            }
        }
    }
}
