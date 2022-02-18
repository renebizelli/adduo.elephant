using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.requests.debts.items;
using Microsoft.AspNetCore.Mvc;

namespace adduo.elephant.api.controllers.debts.items
{
    [Route("v{version:apiVersion}/debts/monthly-bundler")]
    [ApiController]
    public class MonthlyBundlerController : DebtController<MonthlyBundlerRequest, MonthlyBundler>
    {
        public MonthlyBundlerController(IDebtService<MonthlyBundlerRequest, MonthlyBundler> service) : base(service)
        {
        }
    }
}
