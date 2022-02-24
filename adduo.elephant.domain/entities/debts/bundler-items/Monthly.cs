﻿using System;

namespace adduo.elephant.domain.entities.debts.bundler_items
{
    public class Monthly : Item
    {
        public Monthly()
        {

        }

        public Monthly(Guid id, string name, decimal amount, Guid bundlerMonthlyId) : base(id, name, amount, bundlerMonthlyId)
        { }
    }
}
