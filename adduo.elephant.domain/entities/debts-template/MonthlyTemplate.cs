namespace adduo.elephant.domain.entities.debts_template
{
    public class MonthlyTemplate : DebtAmountTemplate
    {
        public MonthlyTemplate()
        {
            Type = enums.DebtType.monthly;
        }

    }
}
