using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.requests;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace adduo.elephant.domain.services.queries.items
{
    public abstract class ItemQueryService<TEntity>  
        where TEntity : entities.debts.items.Item
    {
        protected readonly IItemQueryRepository<TEntity> repository;

        public ItemQueryService(IItemQueryRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public async Task<List<TEntity>> Get(PeriodRequest period)
        {
            var where = WhereGenerator(period);

            var entities = await repository.QueryAsync(where);

            return entities;
        }

        public abstract Expression<Func<TEntity, bool>> WhereGenerator(PeriodRequest period);
    }
}
