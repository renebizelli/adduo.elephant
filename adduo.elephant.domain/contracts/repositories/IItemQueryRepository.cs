using adduo.elephant.domain.entities.debts_template;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.repositories
{
    public interface IItemQueryRepository<T> where T : DebtTemplate
    {
        Task<List<T>> QueryAsync(Expression<Func<T, bool>> e);
    }
}
