using adduo.elephant.domain.entities.debts;
using adduo.elephant.repositories;
using adduo.elephant.repositories.access;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace adduo.elephant.test.repositories
{
    public class BaseRepositoryTest<T> : IDisposable where T : Debt
    {
        public ElephantContext context { get; }
        public UnitOfWork unitOfWork { get; }
        public DebtRepository<T> repository { get; }

        public BaseRepositoryTest()
        {
            var options = new DbContextOptionsBuilder<ElephantContext>()
                                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                                .Options;

            context = new ElephantContext(options);

            context.Database.EnsureCreated();

            unitOfWork = new UnitOfWork(context);

            repository = new DebtRepository<T>(context);
        }

        public async Task SaveAsyncTest(T entity)
        {
            await repository.SaveAsync(entity);
            await unitOfWork.CommitAsync();

            var count = context.Set<T>().Count();

            Assert.Equal(1, count);
        }

        public void Dispose()
        {
            context.Database.EnsureDeleted();
        }
    }
}
