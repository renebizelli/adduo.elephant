using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.contracts.services.queries;
using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.requests;
using System;
using System.Linq.Expressions;

namespace adduo.elephant.domain.services.queries.items
{
    public class PontualQueryService : ItemQueryService<Pontual>, IQueryService<Pontual>
    {
        public PontualQueryService(IItemQueryRepository<Pontual> repository) : base(repository)
        {
        }

        public override Expression<Func<Pontual, bool>> WhereGenerator(PeriodRequest period)
        {
            Expression<Func<Pontual, bool>> where = (debt) =>
                debt.Year == period.Year &&
                debt.Month == period.Month;

            return where;

        }
    }
}
