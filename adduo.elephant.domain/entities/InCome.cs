using adduo.elephant.domain.entities.debts.items;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities
{
    public class InCome : EntityItem<int>
    {
        public virtual ICollection<Item> ItemDebts { get; set; }

        public InCome(int id, string name) : base(id, name)
        {
        }

        public InCome(int id) : base(id)
        {
        }


    }
}
