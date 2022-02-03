using adduo.elephant.domain.contracts.repositories;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.repositories.access
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ElephantContext context;

        public UnitOfWork(ElephantContext context)
        {
            this.context = context;
        }

        public async Task CommitAsync()
        {
            await context.SaveChangesAsync();
        }

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }

        #endregion
    }
}
