using System;
using System.Collections.Generic;
using System.Linq;

namespace adduo.elephant.console
{

    public class DebtRepository
    {
        public Db Db { get; set; }

        public DebtRepository()
        {
            Db = new Db();
        }

        public List<PontualDebt> PontualDebtsList(int month, int year)
        {
            var debts = (from d in Db.Debts.OfType<PontualDebt>()
                         where d.Month == month &&
                         d.Year == year &&
                         d.Status == DebtStatuses.Active
                         select d).ToList();

            return debts;
        }


        public List<MonthlyRecurrenceDebt> MonthlyRecurrenceDebtsList(int month, int year)
        {
            var debts = (from d in Db.Debts.OfType<MonthlyRecurrenceDebt>()
                         where d.Status == DebtStatuses.Active
                         select d).ToList();

            return debts;
        }

        public List<YearlyRecurrenceDebt> YearlyRecurrenceDebtsList(int month, int year)
        {
            var debts = (from d in Db.Debts.OfType<YearlyRecurrenceDebt>()
                         where
                         d.DueMonth == month &&
                         d.Status == DebtStatuses.Active
                         select d).ToList();

            return debts;
        }


        public List<InstallmentsDebt> InstallmentsDebtsList(int month, int year)
        {
            var date = new DateTime(year, month, 1);

            var debts = (from d in Db.Debts.OfType<InstallmentsDebt>()
                         where
                         new DateTime(d.StartYear, d.StartMonth, 1) <= date &&
                         (new DateTime(d.StartYear, d.StartMonth, 1)).AddMonths(d.Installments) >= date &&
                         d.Status == DebtStatuses.Active
                         select d).ToList();

            return debts;
        }

        public List<MonthlyBlunderDebt> MonthlyBundlerDebtsList(int month, int year)
        {
            var debts = (from d in Db.Debts.OfType<MonthlyBlunderDebt>()
                         where
                         d.Status == DebtStatuses.Active
                         select d).ToList();

            return debts;
        }

    }
}
