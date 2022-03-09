using adduo.elephant.domain.entities.debts.items;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.repositories
{
    public interface IItemQueryRepository<T> where T : Item
    {
        Task<List<T>> QueryAsync(Expression<Func<T, bool>> e);
    }
}
