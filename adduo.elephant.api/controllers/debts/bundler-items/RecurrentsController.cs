using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace adduo.elephant.api.controllers.debts.bundler_items
{
    [Route("v{version:apiVersion}/debts/bundler/recurrent")]
    public class RecurrentsController : DebtController<RecurrentBundlerSaveRequest, RecurrentBundlerUpdateRequest, RecurrentBundler>
    {
        private readonly IRecurrenteValueBundlerService valueService;

        public RecurrentsController(IRecurrenteValueBundlerService valueService, IDebtService<RecurrentBundlerSaveRequest, RecurrentBundlerUpdateRequest, RecurrentBundler> service) : base(service)
        {
            this.valueService = valueService;
        }

        [HttpPost("{id}/values")]
        public async Task<IActionResult> AddValue([FromRoute] string id, [FromBody] RecurrentValueBundlerRequest request)
        {
            var response = await valueService.AddValueAsync(id, request);

            return StatusCode((int)response.HttpStatusCode, response);
        }

        [HttpPut("{recurrentId}/values/{valueId}")]
        public async Task<IActionResult> UpdateValue([FromRoute] string recurrentId, [FromRoute] string valueId, [FromBody] RecurrentValueBundlerRequest request)
        {
            var response = await valueService.UpdateValueAsync(recurrentId, valueId, request);

            return StatusCode((int)response.HttpStatusCode, response);
        }
    }
}
