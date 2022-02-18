using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using Microsoft.AspNetCore.Mvc;

namespace adduo.elephant.api.controllers.debts.bundler_items
{
    [Route("v{version:apiVersion}/debts/bundler/pontual")]
    public class PontualController : DebtController<PontualRequest, Pontual>
    {
        public PontualController(IDebtService<PontualRequest, Pontual> service) : base(service)
        {
        }
    }
}
