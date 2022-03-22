using adduo.elephant.domain.contracts.entities;
using adduo.elephant.domain.requests;
using System;

namespace adduo.elephant.domain.extensions
{
    public static class PeriodExtension
    {
        public static int GetStartPeriod(this IInstallment installment)
        {
            return CalculatePeriod(installment.StartYear, installment.StartMonth);
        }

        public static int GetFinishPeriod(this IInstallment installment)
        {
            var finishDate = new DateTime(installment.StartYear, installment.StartMonth, 1).AddMonths(installment.Installments).AddMonths(-1);
            return CalculatePeriod(finishDate.Year, finishDate.Month);
        }

        public static int GetPeriod(this PeriodRequest period)
        {
            return CalculatePeriod(period.Year, period.Month);
        }

        private static int CalculatePeriod(int year, int month)
        {
            return year * 100 + month;
        }
    }
}
