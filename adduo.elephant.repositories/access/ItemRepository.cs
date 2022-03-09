using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace adduo.elephant.repositories.access
{
    public class ItemRepository<T, TId> : IItemRepository<T, TId>  
        where T : EntityItem<TId>
        where TId : struct
    {
        private readonly ElephantContext context;

        public ItemRepository(ElephantContext elephantContext)
        {
            this.context = elephantContext;
        }

        public async Task<T> GetAsync(TId id)
        {
            var entity = await context.Set<T>().FirstOrDefaultAsync(f => f.Id.Equals(id));

            return entity;
        }

        public T Get(TId id)
        {
            var entity = context.Set<T>().FirstOrDefault(f => f.Id.Equals(id));

            return entity;
        }

        public async Task SaveAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
        }
    }
}
