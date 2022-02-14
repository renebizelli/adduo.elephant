using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using Microsoft.AspNetCore.Mvc;

namespace adduo.elephant.api.controllers
{
    [Route("v{version:apiVersion}/debts/installments")]
    [ApiController]
    public class InstallmentsItemDebtController : DebtController<InstallmentsItemDebtRequest, InstallmentsItemDebt>
    {
        public InstallmentsItemDebtController(IDebtService<InstallmentsItemDebtRequest, InstallmentsItemDebt> service) : base(service)
        {
        }
    }
}
