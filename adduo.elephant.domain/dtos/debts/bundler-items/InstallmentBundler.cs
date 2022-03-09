namespace adduo.elephant.domain.dtos.debts.bundler_items
{
    public class InstallmentBundler : ItemAmountBundler
    {
        public int StartMonth { get; set; }
        public int StartYear { get; set; }
        public int Installments { get; set; }
      
    }
}
