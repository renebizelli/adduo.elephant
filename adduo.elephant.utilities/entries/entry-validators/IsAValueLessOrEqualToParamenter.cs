namespace adduo.elephant.utilities.entries.entry_validators
{
    public class IsAValueLessOrEqualToParamenter : IsAnInt
    {
        private readonly int minValue;

        public IsAValueLessOrEqualToParamenter(int minValue) : base()
        {
            this.minValue = minValue;
        }

        public override void Validate()
        {
            base.Validate();

            if (CanValidate())
            {
                var test = int.Parse(entry.Value) >= minValue;
                SetInvalidStatus(test);
            }
        }
    }
}
