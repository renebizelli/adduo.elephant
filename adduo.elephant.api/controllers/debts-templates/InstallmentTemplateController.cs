using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts_template;
using adduo.elephant.domain.requests.debts_template;
using Microsoft.AspNetCore.Mvc;

namespace adduo.elephant.api.controllers.debts_templates
{
    [Route("v{version:apiVersion}/debts-template/installments")]
    public class InstallmentTemplateController : DebtsTemplateController<InstallmentTemplateRequest, InstallmentTemplate>
    {
        public InstallmentTemplateController(IDebtTemplateService<InstallmentTemplateRequest, InstallmentTemplate> debtTemplateService) : base(debtTemplateService)
        {
        }
    }
}
