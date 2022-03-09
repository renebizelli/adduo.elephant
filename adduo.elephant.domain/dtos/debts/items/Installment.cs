namespace adduo.elephant.domain.dtos.debts.items
{
    public class Installment : ItemAmount
    {
        public int StartMonth { get; set; }
        public int StartYear { get; set; }
        public int Installments { get; set; }
    }
}
