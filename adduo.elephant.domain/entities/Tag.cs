using adduo.elephant.domain.entities.debts;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities
{
    public class Tag : EntityItem<int>
    {
        public virtual ICollection<Debt> Debts { get; private set; }
        
        public Tag(int id, string name) 
        {
            Id = id;
            Name = name;
        }

    }
}
