using adduo.elephant.domain.entities.debts;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities
{
    public class InCome : EntityItem<int>
    {
        public virtual List<ItemDebt> ItemDebts { get; set; }
        public InCome(int id, string name) : base(id, name)
        {
        }
    }
}
