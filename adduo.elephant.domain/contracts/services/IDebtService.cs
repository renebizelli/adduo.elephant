using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.services
{
    public interface IDebtService<TSaveRequest, TEntity> : IDebtService<TSaveRequest, TSaveRequest, TEntity>
        where TSaveRequest : DebtRequest
        where TEntity : Debt
    {

    }

    public interface IDebtService<TSaveRequest, TUpdateRequest, TEntity> 
        where TSaveRequest : DebtRequest
        where TUpdateRequest : DebtRequest
        where TEntity : Debt
    {
        Task<TSaveRequest> SaveAsync(TSaveRequest debt);
        Task<TUpdateRequest> UpdateAsync(string id, TUpdateRequest debt);
    }
}
