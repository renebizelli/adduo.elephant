﻿using adduo.elephant.domain.entities.debts;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities
{
    public class InCome : EntityItem<int>
    {
        public InCome(int id, string name) 
        {
            Id = id;
            Name = name;
        }

        public virtual ICollection<ItemDebt> ItemDebts { get; set; }
    }
}
