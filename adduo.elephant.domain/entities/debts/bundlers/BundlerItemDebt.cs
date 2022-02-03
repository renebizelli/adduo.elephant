﻿using System;

namespace adduo.elephant.domain.entities.debts.bundlers
{
    public abstract class BundlerItemDebt : Debt
    {
        public virtual MonthyBundlerItemDebt MonthyBundlerItemDebt { get; set; }
        public virtual Guid MonthyBundlerItemDebtId { get; set; }
        public BundlerItemDebt(Guid id, string name, decimal value, int categoryId, DebtStatuses status) : base(id, name, value, categoryId, status)
        {
        }
    }
}
