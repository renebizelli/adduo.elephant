using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace adduo.elephant.api.controllers.debts
{
    [ApiController]
    [ApiVersion("1.0")]
    public class DebtController<TRequest, TDetb> : ControllerBase 
        where TRequest : DebtRequest
        where TDetb : Debt
    {
        private readonly IDebtService<TRequest, TDetb> service;

        public DebtController(IDebtService<TRequest, TDetb> service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TRequest request)
        {
            var response = await service.SaveAsync(request);

            return StatusCode((int)response.HttpStatusCode, response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] string id, [FromBody] TRequest request)
        {
            var response = await service.UpdateAsync(id, request);

            return StatusCode((int)response.HttpStatusCode, response);
        }
    }
}


