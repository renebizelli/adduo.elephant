using adduo.elephant.domain.requests;
using adduo.elephant.domain.requests.debts.bundler_items;
using System.Collections.Generic;

namespace adduo.elephant.test
{
    public class HelperDebtBundlerItemsTest
    {
        public static InstallmentRequest CreateInstallmentRequest(string name, decimal value, List<int> tags, int startMonth, int startYear, int installments)
        {
            var request = new InstallmentRequest();

            request.StartMonth = new utilities.entries.MonthEntry { Value = startMonth.ToString() };
            request.StartYear = new utilities.entries.IntEntry { Value = startYear.ToString() };
            request.Installments = new utilities.entries.IntEntry { Value = installments.ToString() };

            SetDebt(request, name, tags);
            SetItem(request, value);

            return request;
        }

        public static PontualRequest CreatePontualRequest(string name, decimal value, List<int> tags, int month, int year)
        {
            var request = new PontualRequest();

            request.Month = new utilities.entries.MonthEntry { Value = month.ToString() };
            request.Year = new utilities.entries.IntEntry { Value = year.ToString() };

            SetDebt(request, name, tags);
            SetItem(request, value);

            return request;
        }

        public static MonthlyRequest CreateMonthlyRequest(string name, decimal value, List<int> tags)
        {
            var request = new MonthlyRequest();

            SetDebt(request, name, tags);
            SetItem(request, value);

            return request;
        }

        public static YearlyRequest CreateYearlyRequest(string name, decimal value, List<int> tags, int dueMonth)
        {
            var request = new YearlyRequest();

            request.DueMonth = new utilities.entries.MonthEntry { Value = dueMonth.ToString() };

            SetDebt(request, name, tags);
            SetItem(request, value);

            return request;
        }


        private static void SetItem(ItemRequest request, decimal value)
        {
            request.Value = new utilities.entries.DecimalEntry { Value = value.ToString() };
            request.BundlerMonthly = new utilities.entries.GuidEntry(true);
        }

        public static void SetDebt(DebtRequest request, string name, List<int> tags)
        {
            request.Name = new utilities.entries.NameEntry() { Value = name };
            request.Tags = new utilities.entries.ListEntry<int> { Value = tags };
        }
    }
}
