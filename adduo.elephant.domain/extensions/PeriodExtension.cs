using adduo.elephant.domain.contracts.entities;
using System;

namespace adduo.elephant.domain.extensions
{
    public static class PeriodExtension
    {
        public static int GetStartPeriod(this IInstallment installment)
        {
            return installment.StartYear * 100 + installment.StartMonth;
        }

        public static int GetFinishPeriod(this IInstallment installment)
        {
            var finishDate = new DateTime(installment.StartYear, installment.StartMonth, 1).AddMonths(installment.Installments).AddMonths(-1);
            return finishDate.Year * 100 + finishDate.Month;
        }
    }
}
