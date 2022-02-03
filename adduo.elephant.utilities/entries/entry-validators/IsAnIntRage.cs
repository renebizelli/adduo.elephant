namespace adduo.elephant.utilities.entries.entry_validators
{
    public class IsAnIntRage : IsAnInt
    {
        private readonly int min;
        private readonly int max;

        public IsAnIntRage(int min, int max)
        {
            this.min = min;
            this.max = max;
        }
        public override void Validate()
        {
            base.Validate();

            if (CanValidate())
            {
                var day = int.Parse(entry.Value);
                var test = day >= min && day <= max;
                SetInvalidStatus(test);
            }
        }
    }
}
