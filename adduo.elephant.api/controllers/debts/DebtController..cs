using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace adduo.elephant.api.controllers.debts
{
    [ApiController]
    [ApiVersion("1.0")]
    public class DebtController<TSaveRequest, TEntity> : DebtController<TSaveRequest, TSaveRequest, TEntity>
        where TSaveRequest : DebtRequest
        where TEntity : Debt
    {
        public DebtController(IDebtService<TSaveRequest, TEntity> service) : base(service)
        {
        }
    }

    [ApiController]
    [ApiVersion("1.0")]
    public class DebtController<TSaveRequest, TUpdateRequest, TEntity> : ControllerBase 
        where TSaveRequest : DebtRequest
        where TUpdateRequest : DebtRequest
        where TEntity : Debt
    {
        private readonly IDebtService<TSaveRequest, TUpdateRequest, TEntity> service;

        public DebtController(IDebtService<TSaveRequest, TUpdateRequest, TEntity> service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TSaveRequest request)
        {
            var response = await service.SaveAsync(request);

            return StatusCode((int)response.HttpStatusCode, response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] string id, [FromBody] TUpdateRequest request)
        {
            var response = await service.UpdateAsync(id, request);

            return StatusCode((int)response.HttpStatusCode, response);
        }
    }
}


