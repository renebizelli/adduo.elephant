using System;

namespace adduo.elephant.domain.entities.debts
{
    public enum DebtStatuses : byte
    {
        Active,
        Inactive
    }

    public abstract class Debt : EntityItem<Guid>
    {
        public decimal Value { get; protected set; }
        public int CategoryId { get; private set; }
        public virtual Category Category { get; private set; }
        public DebtStatuses Status { get; private set; }

        public Debt(): base()
        {

        }

        public Debt(Guid id, string name, decimal value, int categoryId, DebtStatuses status) : base(id, name)
        {
            Value = value;
            CategoryId = categoryId;
            Status = status;
        }

        public void Activate()
        {
            Status = DebtStatuses.Active;
        }
    }
}
