namespace adduo.elephant.domain.entities.debts_template
{
    public class PontualTemplate : DebtAmountTemplate
    {
        public int DueMonth { get; private set; }
        public int DueYear { get; private set; }

        public PontualTemplate()
        {
            Type = enums.DebtType.pontual;
        }
    }
}
