﻿using System;

namespace adduo.elephant.domain.entities.debts.bundlers
{
    public abstract class BundlerItemDebt : Debt
    {
        public virtual MonthyBundlerItemDebt MonthyBundlerItemDebt { get; set; }
        public virtual Guid MonthyBundlerItemDebtId { get; set; }
        protected BundlerItemDebt(Guid id, string name, decimal amount) : base(id, name, amount)
        {
        }
    }
}
