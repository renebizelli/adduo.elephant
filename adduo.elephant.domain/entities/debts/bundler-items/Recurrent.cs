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

        public Recurrent(Guid id, string name, string description, decimal value, Guid bundlerMonthlyId) : base(id, name, bundlerMonthlyId)
        {
            AddValue(new RecurrentValue(description, value, id));
        }

        public void AddValue(RecurrentValue value)
        {
            Values.Add(value);
        }


    }
}
