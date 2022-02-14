using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using adduo.elephant.domain.services;
using adduo.elephant.repositories.access;
using Microsoft.Extensions.DependencyInjection;

namespace adduo.elephant.domain.ioc
{
    public static class DependencyInjection
    {
        public static void AddIoC(this IServiceCollection services)
        {
            services.AddScoped<IDebtService<PontualItemDebtRequest, PontualItemDebt>, DebtService<PontualItemDebtRequest, PontualItemDebt>>();
            services.AddScoped<IDebtService<MonthlyRecurrenceItemDebtRequest, MonthlyRecurrenceItemDebt>, DebtService<MonthlyRecurrenceItemDebtRequest, MonthlyRecurrenceItemDebt>>();
            services.AddScoped<IDebtService<YearlyRecurrenceItemDebtRequest, YearlyRecurrenceItemDebt>, DebtService<YearlyRecurrenceItemDebtRequest, YearlyRecurrenceItemDebt>>();
            services.AddScoped<IDebtService<InstallmentsItemDebtRequest, InstallmentsItemDebt>, DebtService<InstallmentsItemDebtRequest, InstallmentsItemDebt>>();

            services.AddScoped<IDebtRepository<PontualItemDebt>, DebtAccess<PontualItemDebt>>();
            services.AddScoped<IDebtRepository<MonthlyRecurrenceItemDebt>, DebtAccess<MonthlyRecurrenceItemDebt>>();
            services.AddScoped<IDebtRepository<YearlyRecurrenceItemDebt>, DebtAccess<YearlyRecurrenceItemDebt>>();
            services.AddScoped<IDebtRepository<InstallmentsItemDebt>, DebtAccess<InstallmentsItemDebt>>();
            services.AddScoped<IItemRepository<Tag, int>, ItemAccess<Tag, int>>();
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
