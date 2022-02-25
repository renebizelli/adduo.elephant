using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.services;
using adduo.elephant.repositories.access;
using Microsoft.Extensions.DependencyInjection;

namespace adduo.elephant.domain.ioc
{
    public static class DependencyInjection
    {
        public static void AddIoC(this IServiceCollection services)
        {
            services.AddScoped<IDebtService<requests.debts.items.InstallmentRequest, entities.debts.items.Installment>, DebtService<requests.debts.items.InstallmentRequest, entities.debts.items.Installment>>();
            services.AddScoped<IDebtService<requests.debts.items.MonthlyBundlerRequest, entities.debts.items.MonthlyBundler>, DebtService<requests.debts.items.MonthlyBundlerRequest, entities.debts.items.MonthlyBundler>>();
            services.AddScoped<IDebtService<requests.debts.items.MonthlyRequest, entities.debts.items.Monthly>, DebtService<requests.debts.items.MonthlyRequest, entities.debts.items.Monthly>>();
            services.AddScoped<IDebtService<requests.debts.items.PontualRequest, entities.debts.items.Pontual>, DebtService<requests.debts.items.PontualRequest, entities.debts.items.Pontual>>();
            services.AddScoped<IDebtService<requests.debts.items.YearlyRequest, entities.debts.items.Yearly>, DebtService<requests.debts.items.YearlyRequest, entities.debts.items.Yearly>>();

            services.AddScoped<IDebtService<requests.debts.bundler_items.InstallmentRequest, entities.debts.bundler_items.Installment>, DebtService<requests.debts.bundler_items.InstallmentRequest, entities.debts.bundler_items.Installment>>();
            services.AddScoped<IDebtService<requests.debts.bundler_items.PontualRequest, entities.debts.bundler_items.Pontual>, DebtService<requests.debts.bundler_items.PontualRequest, entities.debts.bundler_items.Pontual>>();
            services.AddScoped<IDebtService<requests.debts.bundler_items.MonthlyRequest, entities.debts.bundler_items.Monthly>, DebtService<requests.debts.bundler_items.MonthlyRequest, entities.debts.bundler_items.Monthly>>();
            services.AddScoped<IDebtService<requests.debts.bundler_items.YearlyRequest, entities.debts.bundler_items.Yearly>, DebtService<requests.debts.bundler_items.YearlyRequest, entities.debts.bundler_items.Yearly>>();

            services.AddScoped<IDebtRepository<entities.debts.items.Installment>, DebtAccess<entities.debts.items.Installment>>();
            services.AddScoped<IDebtRepository<entities.debts.items.MonthlyBundler>, DebtAccess<entities.debts.items.MonthlyBundler>>();
            services.AddScoped<IDebtRepository<entities.debts.items.Monthly>, DebtAccess<entities.debts.items.Monthly>>();
            services.AddScoped<IDebtRepository<entities.debts.items.Pontual>, DebtAccess<entities.debts.items.Pontual>>();
            services.AddScoped<IDebtRepository<entities.debts.items.Yearly>, DebtAccess<entities.debts.items.Yearly>>();
            
            services.AddScoped<IDebtRepository<entities.debts.bundler_items.Installment>, DebtAccess<entities.debts.bundler_items.Installment>>();
            services.AddScoped<IDebtRepository<entities.debts.bundler_items.Pontual>, DebtAccess<entities.debts.bundler_items.Pontual>>();
            services.AddScoped<IDebtRepository<entities.debts.bundler_items.Monthly>, DebtAccess<entities.debts.bundler_items.Monthly>>();
            services.AddScoped<IDebtRepository<entities.debts.bundler_items.Yearly>, DebtAccess<entities.debts.bundler_items.Yearly>>();

            services.AddScoped<IItemRepository<entities.Category, int>, ItemAccess<entities.Category, int>>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
