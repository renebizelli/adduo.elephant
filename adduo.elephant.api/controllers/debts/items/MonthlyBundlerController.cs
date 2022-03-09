using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.requests.debts.items;
using Microsoft.AspNetCore.Mvc;

namespace adduo.elephant.api.controllers.debts.items
{
    [Route("v{version:apiVersion}/debts/monthly-bundler")]
    public class MonthlyBundlerController : DebtController<BundlerMonthlyRequest, BundlerMonthly>
    {
        public MonthlyBundlerController(IDebtService<BundlerMonthlyRequest, BundlerMonthly> service) : base(service)
        {
        }
    }
}
