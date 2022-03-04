using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace adduo.elephant.api.controllers.debts.bundler_items
{
    [Route("v{version:apiVersion}/debts/bundler/recurrent")]
    [ApiController]
    public class RecurrentsController : DebtController<RecurrentRequest, Recurrent>
    {
        private readonly IRecurrenteValueService valueService;

        public RecurrentsController(IRecurrenteValueService valueService, IDebtService<RecurrentRequest, Recurrent> service) : base(service)
        {
            this.valueService = valueService;
        }

        [HttpPut("{id}/values")]
        public async Task<IActionResult> AddValue([FromRoute] string id, [FromBody] RecurrentValueRequest request)
        {
            var response = await valueService.AddValueAsync(id, request);

            return StatusCode((int)response.HttpStatusCode, response);
        }
    }
}
