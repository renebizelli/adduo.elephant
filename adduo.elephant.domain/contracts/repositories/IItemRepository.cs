using adduo.elephant.domain.entities;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.repositories
{
    public interface IItemRepository<T, TId>
        where T : EntityItem<TId>
        where TId : struct
    {
        Task<T> GetAsync(TId id);
        T Get(TId id);
    }
}
