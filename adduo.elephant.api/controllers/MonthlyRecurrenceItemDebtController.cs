using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using Microsoft.AspNetCore.Mvc;

namespace adduo.elephant.api.controllers
{
    [Route("v{version:apiVersion}/debts/monthly")]
    [ApiController]
    public class MonthlyRecurrenceItemDebtController : DebtController<MonthlyRecurrenceItemDebtRequest, MonthlyRecurrenceItemDebt>
    {
        public MonthlyRecurrenceItemDebtController(IDebtService<MonthlyRecurrenceItemDebtRequest, MonthlyRecurrenceItemDebt> service) : base(service)
        {
        }
    }
}
