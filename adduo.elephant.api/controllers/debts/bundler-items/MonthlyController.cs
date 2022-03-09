using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using Microsoft.AspNetCore.Mvc;

namespace adduo.elephant.api.controllers.debts.bundler_items
{
    [Route("v{version:apiVersion}/debts/bundler/monthly")]
    public class MonthlyController : DebtController<MonthlyBundlerRequest, MonthlyBundler>
    {
        public MonthlyController(IDebtService<MonthlyBundlerRequest, MonthlyBundler> service) : base(service)
        {
        }
    }
}
