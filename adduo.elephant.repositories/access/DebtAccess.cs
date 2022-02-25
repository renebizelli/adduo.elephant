using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.entities.debts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.repositories.access
{
    public class DebtAccess<T> : IDebtRepository<T> where T : Debt
    {
        private readonly ElephantContext context;

        public DebtAccess(ElephantContext elephantContext)
        {
            this.context = elephantContext;
        }

        public Task<T> GetAsync(Guid guid)
        {
            return context.Set<T>().Include(i => i.Category).FirstOrDefaultAsync(f => f.Id.Equals(guid));
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
