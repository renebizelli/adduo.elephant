using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using Microsoft.AspNetCore.Mvc;

namespace adduo.elephant.api.controllers.debts.bundler_items
{
    [Route("v{version:apiVersion}/debts/bundler/installments")]
    public class InstallmentsController : DebtController<InstallmentBundlerRequest, InstallmentBundler>
    {
        public InstallmentsController(IDebtService<InstallmentBundlerRequest, InstallmentBundler> service) : base(service)
        {
        }
    }
}
