using adduo.elephant.domain.entities.debts_template;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities
{
    public class Category : EntityItem<int>
    {
        public Category(int id) : base(id)
        {

        }

        public Category(int id, string name) : base(id, name)
        {
        }
    }
}
