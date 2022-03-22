using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts_template;
using adduo.elephant.domain.requests.debts_template;
using adduo.elephant.domain.services;
using adduo.elephant.repositories.access;
using Microsoft.Extensions.DependencyInjection;

namespace adduo.elephant.domain.ioc
{
    public static class DependencyInjection
    {
        public static void AddIoC(this IServiceCollection services)
        {
            
            services.AddScoped<IDebtTemplateService<BundlerMonthlyTemplateRequest, BundlerMonthlyTemplate>, DebtTemplateService<BundlerMonthlyTemplateRequest, BundlerMonthlyTemplate>>();
            services.AddScoped<IDebtTemplateService<InstallmentTemplateRequest, InstallmentTemplate>, DebtTemplateService<InstallmentTemplateRequest, InstallmentTemplate>>();
            services.AddScoped<IDebtTemplateService<MonthlyTemplateRequest, MonthlyTemplate>, DebtTemplateService<MonthlyTemplateRequest, MonthlyTemplate>>();
            services.AddScoped<IDebtTemplateService<PontualTemplateRequest, PontualTemplate>, DebtTemplateService<PontualTemplateRequest, PontualTemplate>>();
            services.AddScoped<IDebtTemplateService<RecurrentTemplateRequest, RecurrentTemplate>, DebtTemplateService<RecurrentTemplateRequest, RecurrentTemplate>>();
            services.AddScoped<IDebtTemplateService<YearlyTemplateRequest, YearlyTemplate>, DebtTemplateService<YearlyTemplateRequest, YearlyTemplate>>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDebtTemplateRepository<BundlerMonthlyTemplate>, DebtTemplateRepository<BundlerMonthlyTemplate>>();
            services.AddScoped<IDebtTemplateRepository<InstallmentTemplate>, DebtTemplateRepository<InstallmentTemplate>>();
            services.AddScoped<IDebtTemplateRepository<MonthlyTemplate>, DebtTemplateRepository<MonthlyTemplate>>();
            services.AddScoped<IDebtTemplateRepository<PontualTemplate>, DebtTemplateRepository<PontualTemplate>>();
            services.AddScoped<IDebtTemplateRepository<RecurrentTemplate>, DebtTemplateRepository<RecurrentTemplate>>();
            services.AddScoped<IDebtTemplateRepository<YearlyTemplate>, DebtTemplateRepository<YearlyTemplate>>();

            //services.AddScoped<ISpreadSheetService, SpreadSheetService>();
            //services.AddScoped<ISpreadSheetRepository, SpreadSheetRepository>();
        }
    }
}
