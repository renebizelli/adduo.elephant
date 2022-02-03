using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.contracts.services;
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
            services.AddScoped<IDebtService<PontualItemDebtRequest, PontualItemDebt>, PontualService>();

            services.AddScoped<IDebtRepository<PontualItemDebt>, DebtAccess<PontualItemDebt>>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
