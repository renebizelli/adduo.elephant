using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.contracts.services.queries;
using adduo.elephant.domain.services;
using adduo.elephant.domain.services.queries;
using adduo.elephant.domain.services.queries.items;
using adduo.elephant.repositories.access;
using Microsoft.Extensions.DependencyInjection;

namespace adduo.elephant.domain.ioc
{
    public static class DependencyInjection
    {
        public static void AddIoC(this IServiceCollection services)
        {
            services.AddScoped<IDebtService<requests.debts.items.InstallmentRequest, entities.debts.items.Installment>, DebtService<requests.debts.items.InstallmentRequest, entities.debts.items.Installment>>();
            services.AddScoped<IDebtService<requests.debts.items.BundlerMonthlyRequest, entities.debts.items.BundlerMonthly>, DebtService<requests.debts.items.BundlerMonthlyRequest, entities.debts.items.BundlerMonthly>>();
            services.AddScoped<IDebtService<requests.debts.items.MonthlyRequest, entities.debts.items.Monthly>, DebtService<requests.debts.items.MonthlyRequest, entities.debts.items.Monthly>>();
            services.AddScoped<IDebtService<requests.debts.items.PontualRequest, entities.debts.items.Pontual>, DebtService<requests.debts.items.PontualRequest, entities.debts.items.Pontual>>();
            services.AddScoped<IDebtService<requests.debts.items.YearlyRequest, entities.debts.items.Yearly>, DebtService<requests.debts.items.YearlyRequest, entities.debts.items.Yearly>>();

            services.AddScoped<IDebtService<requests.debts.bundler_items.InstallmentBundlerRequest, entities.debts.bundler_items.InstallmentBundler>, DebtService<requests.debts.bundler_items.InstallmentBundlerRequest, entities.debts.bundler_items.InstallmentBundler>>();
            services.AddScoped<IDebtService<requests.debts.bundler_items.PontualBundlerRequest, entities.debts.bundler_items.PontualBundler>, DebtService<requests.debts.bundler_items.PontualBundlerRequest, entities.debts.bundler_items.PontualBundler>>();
            services.AddScoped<IDebtService<requests.debts.bundler_items.MonthlyBundlerRequest, entities.debts.bundler_items.MonthlyBundler>, DebtService<requests.debts.bundler_items.MonthlyBundlerRequest, entities.debts.bundler_items.MonthlyBundler>>();
            services.AddScoped<IDebtService<requests.debts.bundler_items.YearlyBundlerRequest, entities.debts.bundler_items.YearlyBundler>, DebtService<requests.debts.bundler_items.YearlyBundlerRequest, entities.debts.bundler_items.YearlyBundler>>();
            services.AddScoped<IDebtService<requests.debts.bundler_items.RecurrentBundlerSaveRequest, requests.debts.bundler_items.RecurrentBundlerUpdateRequest, entities.debts.bundler_items.RecurrentBundler>, DebtService<requests.debts.bundler_items.RecurrentBundlerSaveRequest, requests.debts.bundler_items.RecurrentBundlerUpdateRequest, entities.debts.bundler_items.RecurrentBundler>>();
            services.AddScoped<IRecurrenteValueBundlerService, RecurrenteValueService>();

            services.AddScoped<IDebtRepository<entities.debts.items.Installment>, DebtRepository<entities.debts.items.Installment>>();
            services.AddScoped<IDebtRepository<entities.debts.items.BundlerMonthly>, DebtRepository<entities.debts.items.BundlerMonthly>>();
            services.AddScoped<IDebtRepository<entities.debts.items.Monthly>, DebtRepository<entities.debts.items.Monthly>>();
            services.AddScoped<IDebtRepository<entities.debts.items.Pontual>, DebtRepository<entities.debts.items.Pontual>>();
            services.AddScoped<IDebtRepository<entities.debts.items.Yearly>, DebtRepository<entities.debts.items.Yearly>>();
            
            services.AddScoped<IDebtRepository<entities.debts.bundler_items.InstallmentBundler>, DebtRepository<entities.debts.bundler_items.InstallmentBundler>>();
            services.AddScoped<IDebtRepository<entities.debts.bundler_items.PontualBundler>, DebtRepository<entities.debts.bundler_items.PontualBundler>>();
            services.AddScoped<IDebtRepository<entities.debts.bundler_items.MonthlyBundler>, DebtRepository<entities.debts.bundler_items.MonthlyBundler>>();
            services.AddScoped<IDebtRepository<entities.debts.bundler_items.YearlyBundler>, DebtRepository<entities.debts.bundler_items.YearlyBundler>>();
            services.AddScoped<IDebtRepository<entities.debts.bundler_items.RecurrentBundler>, DebtRepository<entities.debts.bundler_items.RecurrentBundler>>();
            services.AddScoped<IRecurrentValueBundlerRepository, RecurrenteValueBundlerRepository>();

            services.AddScoped<IItemRepository<entities.Category, int>, ItemRepository<entities.Category, int>>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ISpreadSheetService, SpreadSheetService>();
            services.AddScoped<ISpreadSheetRepository, SpreadSheetRepository>();

            services.AddScoped<IQueryService<entities.debts.items.Pontual>, PontualQueryService>();
            services.AddScoped<IItemQueryRepository<entities.debts.items.Pontual>, ItemQueryRepository<entities.debts.items.Pontual>>();

            services.AddScoped<IQueryService<entities.debts.items.Monthly>, MonthlyQueryService>();
            services.AddScoped<IItemQueryRepository<entities.debts.items.Monthly>, ItemQueryRepository<entities.debts.items.Monthly>>();

            services.AddScoped<IQueryService<entities.debts.items.Yearly>, YearlyQueryService>();
            services.AddScoped<IItemQueryRepository<entities.debts.items.Yearly>, ItemQueryRepository<entities.debts.items.Yearly>>();

            services.AddScoped<IQueryService<entities.debts.items.Installment>, InstallmentQueryService>();
            services.AddScoped<IItemQueryRepository<entities.debts.items.Installment>, ItemQueryRepository<entities.debts.items.Installment>>();

        }
    }
}
