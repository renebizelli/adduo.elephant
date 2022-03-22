using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts_template;
using adduo.elephant.domain.requests.debts_template;
using Microsoft.AspNetCore.Mvc;

namespace adduo.elephant.api.controllers.debts_templates
{
    [Route("v{version:apiVersion}/debts-template/bundler-monthly")]
    public class BundlerMonthlyTemplateController : DebtsTemplateController<BundlerMonthlyTemplateRequest, BundlerMonthlyTemplate>
    {
        public BundlerMonthlyTemplateController(IDebtTemplateService<BundlerMonthlyTemplateRequest, BundlerMonthlyTemplate> debtTemplateService) : base(debtTemplateService)
        {
        }
    }
}
