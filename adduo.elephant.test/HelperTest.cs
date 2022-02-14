using adduo.elephant.domain.requests;
using System.Collections.Generic;

namespace adduo.elephant.test
{
    public class HelperTest
    {
        public static PontualItemDebtRequest CreatePontualItemDebtRequest(string name, decimal value, int dueDay, List<int> tags, int inComeId, int month, int year)
        {
            var request = new PontualItemDebtRequest();

            request.Month = new utilities.entries.MonthEntry { Value = month.ToString() };
            request.Year = new utilities.entries.IntEntry { Value = year.ToString() };

            SetItemDebtBase(request, dueDay, inComeId);
            SetDebtBase(request, name, value, tags);

            return request;
        }

        public static MonthlyRecurrenceItemDebtRequest CreateMonthlyRecurrenceItemDebtRequest(string name, decimal value, int dueDay, List<int> tags, int inComeId)
        {
            var request = new MonthlyRecurrenceItemDebtRequest();

            SetItemDebtBase(request, dueDay, inComeId);
            SetDebtBase(request, name, value, tags);

            return request;
        }

        public static YearlyRecurrenceItemDebtRequest CreateYearlyRecurrenceItemDebtRequest(string name, decimal value, int dueDay, List<int> tags, int inComeId, int dueMonth)
        {
            var request = new YearlyRecurrenceItemDebtRequest();

            request.DueMonth = new utilities.entries.MonthEntry { Value = dueMonth.ToString() };

            SetItemDebtBase(request, dueDay, inComeId);
            SetDebtBase(request, name, value, tags);

            return request;
        }

        private static void SetItemDebtBase(ItemDebtRequest request, int dueDay, int inComeId)
        {
            request.InComeId = new utilities.entries.IntEntry { Value = inComeId.ToString() };
            request.DueDay = new utilities.entries.DayEntry { Value = dueDay.ToString() };
        }

        public static void SetDebtBase(DebtRequest request, string name, decimal value, List<int> tags)
        {
            request.Name = new utilities.entries.NameEntry() { Value = name };
            request.Value = new utilities.entries.DecimalEntry { Value = value.ToString() };
            request.Tags = new utilities.entries.ListEntry<int> { Value = tags };
        }
    }
}
