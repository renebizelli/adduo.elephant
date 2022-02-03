using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using AutoMapper;

namespace adduo.elephant.domain.services
{
    public class PontualService : DebtService<PontualItemDebtRequest, PontualItemDebt>
    {
        public PontualService(IMapper mapper, IDebtRepository<PontualItemDebt> repository, IUnitOfWork unitOfWork) : base(mapper, repository, unitOfWork)
        {
        }
    }
}
