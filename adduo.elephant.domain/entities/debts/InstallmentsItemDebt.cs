namespace adduo.elephant.domain.entities.debts
{
    public class InstallmentsItemDebt : ItemDebt
    {
        public int StartMonth { get; private set; }
        public int StartYear { get; private set; }
        public int Installments { get; private set; }
    }
}
