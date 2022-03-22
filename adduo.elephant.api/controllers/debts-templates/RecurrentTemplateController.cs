using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts_template;
using adduo.elephant.domain.requests.debts_template;
using Microsoft.AspNetCore.Mvc;

namespace adduo.elephant.api.controllers.debts_templates
{
    [Route("v{version:apiVersion}/debts-template/recurrent")]
    public class RecurrentTemplateController : DebtsTemplateController<RecurrentTemplateRequest, RecurrentTemplate>
    {
        public RecurrentTemplateController(IDebtTemplateService<RecurrentTemplateRequest, RecurrentTemplate> debtTemplateService) : base(debtTemplateService)
        {
        }
    }
}
