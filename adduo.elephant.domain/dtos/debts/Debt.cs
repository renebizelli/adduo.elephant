using adduo.elephant.domain.enums;
using System;

namespace adduo.elephant.domain.dtos.debts
{
    public abstract class Debt  
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual Category Category { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public DebtType Type { get; set; }
    }
}
