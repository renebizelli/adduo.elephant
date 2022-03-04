using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class Recurrent : Item
    {
        public List<RecurrentValue> Values { get; private set; } = new List<RecurrentValue>();

        public Recurrent()
        {
        }

        public Recurrent(Guid id, string name, Guid bundlerMonthlyId) : base(id, name, bundlerMonthlyId)
        {
        }

        public void AddValue(RecurrentValue value)
        {
            Values.Add(value);
        }


    }
}
