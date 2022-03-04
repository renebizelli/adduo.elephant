using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.entities.debts.bundler_items;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.repositories.access
{
    public class RecurrenteValueAccess : IRecurrentValueRepository
    {
        private readonly ElephantContext context;

        public RecurrenteValueAccess(ElephantContext elephantContext)
        {
            this.context = elephantContext;
        }

        public async Task AddValueAsync(Guid id, RecurrentValue value)
        {
            var recurrent = await context.Set<Recurrent>()
                .Include(i => i.Values)
                .FirstOrDefaultAsync(f => f.Id.Equals(id));

            if(recurrent is Recurrent)
            {
                recurrent.Values.Add(value);
            }
        }
    }
}
