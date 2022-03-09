namespace adduo.elephant.domain.dtos.debts.items
{
    public abstract class Item : Debt
    {
        public int DueDay { get; set; }
        public virtual InCome InCome { get; set; }
    }
}
