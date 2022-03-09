using adduo.elephant.domain.requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.services.queries
{
    public interface IQueryService<TEntity>
        where TEntity : entities.debts.Debt
    {
        Task<List<TEntity>> Get(PeriodRequest period);
    }
}
