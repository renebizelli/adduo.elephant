using adduo.elephant.domain.requests;
using adduo.elephant.domain.requests.debts.bundler_items;
using System;

namespace adduo.elephant.test
{
    public class HelperDebtBundlerItemsTest
    {
        public static InstallmentBundlerRequest CreateInstallmentRequest(string name, decimal value, int category, int startMonth, int startYear, int installments, Guid bundlerMonthly)
        {
            var request = new InstallmentBundlerRequest();

            request.StartMonth = new utilities.entries.MonthEntry { Value = startMonth.ToString() };
            request.StartYear = new utilities.entries.IntEntry { Value = startYear.ToString() };
            request.Installments = new utilities.entries.IntEntry { Value = installments.ToString() };

            SetDebt(request, name, category);
            SetItem(request, bundlerMonthly);
            SetItemAmount(request, value);

            return request;
        }

        public static PontualBundlerRequest CreatePontualRequest(string name, decimal value, int category, int month, int year, Guid bundlerMonthly)
        {
            var request = new PontualBundlerRequest();

            request.Month = new utilities.entries.MonthEntry { Value = month.ToString() };
            request.Year = new utilities.entries.IntEntry { Value = year.ToString() };

            SetDebt(request, name, category);
            SetItem(request, bundlerMonthly);
            SetItemAmount(request, value);

            return request;
        }

        public static MonthlyBundlerRequest CreateMonthlyRequest(string name, decimal value, int category, Guid bundlerMonthly)
        {
            var request = new MonthlyBundlerRequest();

            SetDebt(request, name, category);
            SetItem(request, bundlerMonthly);
            SetItemAmount(request, value);

            return request;
        }

        public static RecurrentBundlerSaveRequest CreateRecurrentSaveRequest(string name, string description, decimal value, int category, Guid bundlerMonthly)
        {
            var request = new RecurrentBundlerSaveRequest();

            request.Value.Value = value.ToString();
            request.Description.Value = description;

            SetDebt(request, name, category);
            SetItem(request, bundlerMonthly);

            return request;
        }

        public static RecurrentBundlerUpdateRequest CreateRecurrentUpdateRequest(string name, int category, Guid bundlerMonthly)
        {
            var request = new RecurrentBundlerUpdateRequest();

            SetDebt(request, name, category);
            SetItem(request, bundlerMonthly);

            return request;
        }
        public static RecurrentValueBundlerRequest CreateRecurrentValueRequest(string description, decimal value)
        {
            var request = new RecurrentValueBundlerRequest();

            request.Description.Value = description;
            request.Amount.Value = value.ToString();

            return request;
        }

        public static YearlyBundlerRequest CreateYearlyRequest(string name, decimal value, int category, int dueMonth, Guid bundlerMonthly)
        {
            var request = new YearlyBundlerRequest();

            request.DueMonth = new utilities.entries.MonthEntry { Value = dueMonth.ToString() };

            SetDebt(request, name, category);
            SetItem(request, bundlerMonthly);
            SetItemAmount(request, value);

            return request;
        }


        private static void SetItem(ItemBundlerRequest request, Guid bundlerMonthly)
        {
            request.BundlerMonthly = new utilities.entries.GuidEntry() { Value = bundlerMonthly.ToString() };
        }

        private static void SetItemAmount(ItemAmountBundlerRequest request, decimal value)
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
