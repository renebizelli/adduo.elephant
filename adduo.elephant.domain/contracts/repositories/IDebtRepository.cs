using adduo.elephant.domain.entities.debts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.repositories
{
    public interface IDebtRepository<T> where T : Debt
    {
        Task SaveAsync(T entity);
        void Update(T entity);
        Task<T> GetAsync(Guid guid);
    }
}
