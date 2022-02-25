using adduo.elephant.domain.entities.debts;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities
{
    public class Category : EntityItem<int>
    {
        public virtual ICollection<Debt> Debts { get; private set; }

        public Category(int id) : base(id)
        {

        }

        public Category(int id, string name) : base(id, name)
        {
        }
    }
}
