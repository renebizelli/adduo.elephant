using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class RecurrentBundler : ItemBundler
    {
        public List<RecurrentBundlerValue> Values { get; private set; } = new List<RecurrentBundlerValue>();

        public RecurrentBundler()
        {
        }

        public RecurrentBundler(Guid id, string name, string description, decimal value, Guid bundlerMonthlyId) : base(id, name, bundlerMonthlyId)
        {
            AddValue(new RecurrentBundlerValue(description, value, id));
        }

        public void AddValue(RecurrentBundlerValue value)
        {
            Values.Add(value);
        }


    }
}
