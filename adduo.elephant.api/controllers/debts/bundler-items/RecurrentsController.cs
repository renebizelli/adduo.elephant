using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace adduo.elephant.api.controllers.debts.bundler_items
{
    [Route("v{version:apiVersion}/debts/bundler/recurrent")]
    [ApiController]
    public class RecurrentsController : DebtController<RecurrentSaveRequest, RecurrentUpdateRequest, Recurrent>
    {
        private readonly IRecurrenteValueService valueService;

        public RecurrentsController(IRecurrenteValueService valueService, IDebtService<RecurrentSaveRequest, RecurrentUpdateRequest, Recurrent> service) : base(service)
        {
            this.valueService = valueService;
        }

        [HttpPost("{id}/values")]
        public async Task<IActionResult> AddValue([FromRoute] string id, [FromBody] RecurrentValueRequest request)
        {
            var response = await valueService.AddValueAsync(id, request);

            return StatusCode((int)response.HttpStatusCode, response);
        }

        [HttpPut("{recurrentId}/values/{valueId}")]
        public async Task<IActionResult> UpdateValue([FromRoute] string recurrentId, [FromRoute] string valueId, [FromBody] RecurrentValueRequest request)
        {
            var response = await valueService.UpdateValueAsync(recurrentId, valueId, request);

            return StatusCode((int)response.HttpStatusCode, response);
        }
    }
}
