namespace adduo.elephant.domain.entities.debts.bundlers
{
    public class InstallmentsBundlerItemDebt : BundlerItemDebt
    {
        public int StartMonth { get; private set; }
        public int StartYear { get; private set; }
        public int Installments { get; private set; }
    
    }
}
