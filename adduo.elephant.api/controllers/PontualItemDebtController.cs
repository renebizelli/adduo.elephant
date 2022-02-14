using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using Microsoft.AspNetCore.Mvc;

namespace adduo.elephant.api.controllers
{
    [Route("v{version:apiVersion}/debts/pontual")]
    public class PontualItemDebtController : DebtController<PontualItemDebtRequest, PontualItemDebt>
    {
        public PontualItemDebtController(IDebtService<PontualItemDebtRequest, PontualItemDebt> service) : base(service)
        {
        }
    }
}
