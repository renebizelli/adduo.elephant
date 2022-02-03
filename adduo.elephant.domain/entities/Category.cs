using adduo.elephant.domain.entities.debts;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities
{
    public class Category : EntityItem<int>
    {
        public virtual List<Debt> Debts { get; private set; }

        public Category(int id, string name) : base(id, name)
        {
        }
    }
}
