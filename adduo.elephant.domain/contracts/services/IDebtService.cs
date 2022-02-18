using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.services
{
    public interface IDebtService<TRequest, TEntity> 
        where TRequest : DebtRequest
        where TEntity : Debt
    {
        Task<TRequest> SaveAsync(TRequest debt);
        Task<TRequest> UpdateAsync(string id, TRequest debt);
    }
}
