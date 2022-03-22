using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.entities.debts_template;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.repositories.access
{
    public class DebtTemplateRepository<T> : IDebtTemplateRepository<T> where T : DebtTemplate
    {
        private readonly ElephantContext context;

        public DebtTemplateRepository(ElephantContext elephantContext)
        {
            this.context = elephantContext;
        }

        public async Task<T> GetAsync(Guid guid)
        {
            return await context.Set<T>()
                .Include(i => i.Category)
                .FirstOrDefaultAsync(f => f.Id.Equals(guid));
        }

        public async Task SaveAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }


    }

}
