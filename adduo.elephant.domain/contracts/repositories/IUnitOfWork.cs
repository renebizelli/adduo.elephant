using System;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task CommitAsync();
    }
}
