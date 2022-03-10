namespace adduo.elephant.domain.contracts.entities
{
    public interface IInstallment
    {
        public int StartMonth { get; }
        public int StartYear { get; }
        public int Installments { get; }
    }
}
