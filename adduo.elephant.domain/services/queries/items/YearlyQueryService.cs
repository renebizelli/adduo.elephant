using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.contracts.services.queries;
using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.requests;
using System;
using System.Linq.Expressions;

namespace adduo.elephant.domain.services.queries.items
{
    public class YearlyQueryService : ItemQueryService<Yearly>, IQueryService<Yearly>
    {
        public YearlyQueryService(IItemQueryRepository<Yearly> repository) : base(repository)
        {
        }

        public override Expression<Func<Yearly, bool>> WhereGenerator(PeriodRequest period)
        {
            Expression<Func<Yearly, bool>> where = (debt) => debt.DueMonth == period.Month;

            return where;

        }
    }
}
