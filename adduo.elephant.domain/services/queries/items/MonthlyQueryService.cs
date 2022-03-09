using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.contracts.services.queries;
using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.requests;
using System;
using System.Linq.Expressions;

namespace adduo.elephant.domain.services.queries.items
{
    public class MonthlyQueryService : ItemQueryService<Monthly>, IQueryService<Monthly>
    {
        public MonthlyQueryService(IItemQueryRepository<Monthly> repository) : base(repository)
        {
        }

        public override Expression<Func<Monthly, bool>> WhereGenerator(PeriodRequest period)
        {
            Expression<Func<Monthly, bool>> where = (debt) => true;

            return where;

        }
    }
}
