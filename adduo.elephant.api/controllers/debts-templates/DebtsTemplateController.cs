
using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts_template;
using adduo.elephant.domain.requests.debts_template;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace adduo.elephant.api.controllers.debts_templates
{
    public abstract class DebtsTemplateController<TRequest, TEntity> : BaseController
        where TRequest : DebtTemplateRequest
        where TEntity : DebtTemplate
    {
        private readonly IDebtTemplateService<TRequest, TEntity> debtTemplateService;

        public DebtsTemplateController(IDebtTemplateService<TRequest, TEntity> debtTemplateService)
        {
            this.debtTemplateService = debtTemplateService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(TRequest request)
        {
            var response = await debtTemplateService.SaveAsync(request);

            return StatusCode((int)response.HttpStatusCode, response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] string id,  TRequest request)
        {
            var response = await debtTemplateService.UpdateAsync(id, request);

            return StatusCode((int)response.HttpStatusCode, response);
        }
    }
}
