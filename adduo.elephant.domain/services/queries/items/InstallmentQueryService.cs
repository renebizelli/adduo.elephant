using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.contracts.services.queries;
using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace adduo.elephant.domain.services.queries.items
{
    public class InstallmentQueryService : ItemQueryService<Installment>, IQueryService<Installment>
    {
        public InstallmentQueryService(IItemQueryRepository<Installment> repository) : base(repository)
        {
        }

        public override Expression<Func<Installment, bool>> WhereGenerator(PeriodRequest period)
        {
            Expression<Func<Installment, bool>> where = (debt) => true;

            return where;

        }
    }
}
