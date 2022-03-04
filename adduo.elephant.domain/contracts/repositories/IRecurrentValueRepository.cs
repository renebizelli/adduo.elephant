using adduo.elephant.domain.entities.debts.bundler_items;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.repositories
{
    public interface IRecurrentValueRepository
    {
        Task AddValueAsync(Guid id, RecurrentValue value);
    }
}
