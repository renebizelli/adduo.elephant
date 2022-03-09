using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.entities.debts.bundler_items;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.repositories.access
{
    public class RecurrenteValueBundlerRepository : IRecurrentValueBundlerRepository
    {
        private readonly ElephantContext context;

        public RecurrenteValueBundlerRepository(ElephantContext elephantContext)
        {
            this.context = elephantContext;
        }

        public async Task AddValueAsync(Guid id, RecurrentBundlerValue value)
        {
            var recurrent = await context.Set<RecurrentBundler>()
                .Include(i => i.Values)
                .FirstOrDefaultAsync(f => f.Id.Equals(id));

            if(recurrent is RecurrentBundler)
            {
                recurrent.Values.Add(value);
            }
        }

        public async Task<RecurrentBundlerValue> GetAsync(Guid recurrentId, int valueId)
        {
            var value = await context.Set<RecurrentBundlerValue>().FirstOrDefaultAsync(f => f.RecurrentId.Equals(recurrentId) && f.Id.Equals(valueId));

            return value;
        }

        public void UpdateValue(RecurrentBundlerValue entity)
        {
            context.Set<RecurrentBundlerValue>().Update(entity);
        }
    }
}
