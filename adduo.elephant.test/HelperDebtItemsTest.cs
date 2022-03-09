using adduo.elephant.domain.requests;
using adduo.elephant.domain.requests.debts.items;
using System.Collections.Generic;

namespace adduo.elephant.test
{
    public class HelperDebtItemsTest
    {
        public static InstallmentRequest CreateInstallmentRequest(string name, decimal value, int dueDay, int category, int inComeId, int startMonth, int startYear, int installments)
        {
            var request = new InstallmentRequest();

            request.StartMonth = new utilities.entries.MonthEntry { Value = startMonth.ToString() };
            request.StartYear = new utilities.entries.IntEntry { Value = startYear.ToString() };
            request.Installments = new utilities.entries.IntEntry { Value = installments.ToString() };

            SetDebt(request, name, category);
            SetItem(request, dueDay, inComeId);
            SetItemAmount(request, value);

            return request;
        }

        public static BundlerMonthlyRequest CreateMonthlyBundlerRequest(string name, int dueDay, int category, int inComeId)
        {
            var request = new BundlerMonthlyRequest();

            SetDebt(request, name, category);
            SetItem(request, dueDay, inComeId);

            return request;
        }
        public static MonthlyRequest CreateMonthlyRequest(string name, decimal value, int dueDay, int category, int inComeId)
        {
            var request = new MonthlyRequest();

            SetDebt(request, name, category);
            SetItem(request, dueDay, inComeId);
            SetItemAmount(request, value);

            return request;
        }

        public static PontualRequest CreatePontualRequest(string name, decimal value, int dueDay, int category, int inComeId, int month, int year)
        {
            var request = new PontualRequest();

            request.Month = new utilities.entries.MonthEntry { Value = month.ToString() };
            request.Year = new utilities.entries.IntEntry { Value = year.ToString() };

            SetDebt(request, name, category);
            SetItem(request, dueDay, inComeId);
            SetItemAmount(request, value);

            return request;
        }

        public static YearlyRequest CreateYearlyRequest(string name, decimal value, int dueDay, int category, int inComeId, int dueMonth)
        {
            var request = new YearlyRequest();

            request.DueMonth = new utilities.entries.MonthEntry { Value = dueMonth.ToString() };

            SetDebt(request, name, category);
            SetItem(request, dueDay, inComeId);
            SetItemAmount(request, value);

            return request;
        }





        private static void SetItem(ItemRequest request, int dueDay, int inComeId)
        {
            request.InComeId = new utilities.entries.IntEntry { Value = inComeId.ToString() };
            request.DueDayOfMonth = new utilities.entries.DayEntry { Value = dueDay.ToString() };
        }


        private static void SetItemAmount(ItemAmountRequest request, decimal value)
        {
            request.Amount = new utilities.entries.DecimalEntry { Value = value.ToString() };
        }

        public static void SetDebt(DebtRequest request, string name, int categoryId)
        {
            request.Name = new utilities.entries.NameEntry() { Value = name };
            request.CategoryId = new utilities.entries.IntEntry { Value = categoryId.ToString() };
        }
    }
}
