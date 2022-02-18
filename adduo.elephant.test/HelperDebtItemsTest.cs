using adduo.elephant.domain.requests;
using adduo.elephant.domain.requests.debts.items;
using System.Collections.Generic;

namespace adduo.elephant.test
{
    public class HelperDebtItemsTest
    {
        public static InstallmentRequest CreateInstallmentRequest(string name, decimal value, int dueDay, List<int> tags, int inComeId, int startMonth, int startYear, int installments)
        {
            var request = new InstallmentRequest();

            request.StartMonth = new utilities.entries.MonthEntry { Value = startMonth.ToString() };
            request.StartYear = new utilities.entries.IntEntry { Value = startYear.ToString() };
            request.Installments = new utilities.entries.IntEntry { Value = installments.ToString() };

            SetDebt(request, name, tags);
            SetItem(request, dueDay, inComeId);
            SetItemAmount(request, value);

            return request;
        }

        public static MonthlyBundlerRequest CreateMonthlyBundlerRequest(string name, int dueDay, List<int> tags, int inComeId)
        {
            var request = new MonthlyBundlerRequest();

            SetDebt(request, name, tags);
            SetItem(request, dueDay, inComeId);

            return request;
        }
        public static MonthlyRequest CreateMonthlyRequest(string name, decimal value, int dueDay, List<int> tags, int inComeId)
        {
            var request = new MonthlyRequest();

            SetDebt(request, name, tags);
            SetItem(request, dueDay, inComeId);
            SetItemAmount(request, value);

            return request;
        }

        public static PontualRequest CreatePontualRequest(string name, decimal value, int dueDay, List<int> tags, int inComeId, int month, int year)
        {
            var request = new PontualRequest();

            request.Month = new utilities.entries.MonthEntry { Value = month.ToString() };
            request.Year = new utilities.entries.IntEntry { Value = year.ToString() };

            SetDebt(request, name, tags);
            SetItem(request, dueDay, inComeId);
            SetItemAmount(request, value);

            return request;
        }

        public static YearlyRequest CreateYearlyRequest(string name, decimal value, int dueDay, List<int> tags, int inComeId, int dueMonth)
        {
            var request = new YearlyRequest();

            request.DueMonth = new utilities.entries.MonthEntry { Value = dueMonth.ToString() };

            SetDebt(request, name, tags);
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
            request.Value = new utilities.entries.DecimalEntry { Value = value.ToString() };
        }

        public static void SetDebt(DebtRequest request, string name,  List<int> tags)
        {
            request.Name = new utilities.entries.NameEntry() { Value = name };
            request.Tags = new utilities.entries.ListEntry<int> { Value = tags };
        }
    }
}
