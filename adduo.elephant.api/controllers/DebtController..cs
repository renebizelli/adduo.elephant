using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace adduo.elephant.api.controllers
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

        public async Task<IActionResult> Post([FromBody] TRequest request)
        {
            var response = await service.SaveAsync(request);

            return StatusCode((int)response.HttpStatusCode, response);
        }
    }
}


