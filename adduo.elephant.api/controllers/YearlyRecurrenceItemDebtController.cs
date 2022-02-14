using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using Microsoft.AspNetCore.Mvc;

namespace adduo.elephant.api.controllers
{
    [Route("v{version:apiVersion}/debts/yearly")]
    [ApiController]
    public class YearlyRecurrenceItemDebtController : DebtController<YearlyRecurrenceItemDebtRequest, YearlyRecurrenceItemDebt>
    {
        public YearlyRecurrenceItemDebtController(IDebtService<YearlyRecurrenceItemDebtRequest, YearlyRecurrenceItemDebt> service) : base(service)
        {
        }
    }
}
