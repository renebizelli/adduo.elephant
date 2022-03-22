namespace adduo.elephant.domain.entities.debts_template
{
    public class YearlyTemplate : DebtAmountTemplate
    {
        public int DueMonth { get; private set; }

        public YearlyTemplate()
        {
            Type = enums.DebtType.yearly;
        }
    }
}
