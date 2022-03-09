using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.entities.debts.items;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace adduo.elephant.repositories.access
{
    public class ItemQueryRepository<T> : IItemQueryRepository<T> 
        where T : Item
    {
        private readonly ElephantContext context;

        public ItemQueryRepository(ElephantContext elephantContext)
        {
            this.context = elephantContext;
        }

        public async Task<List<T>> QueryAsync(Expression<Func<T, bool>> e)
        {
            return await context.Set<T>()
                                .Include(i => i.Category)
                                .Include(i => i.InCome)
                                .Where(e)
                                .Where(w => w.Status == DebtStatuses.Active)
                                .AsSplitQuery()
                                .ToListAsync();
        }
    }
}
