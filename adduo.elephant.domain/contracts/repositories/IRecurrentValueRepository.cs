using adduo.elephant.domain.entities.debts.bundler_items;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.repositories
{
    public interface IRecurrentValueRepository
    {
        Task AddValueAsync(Guid recurrentId, RecurrentValue value);
        void UpdateValue(RecurrentValue value);
        Task<RecurrentValue> GetAsync(Guid recurrentId, int valueId);
    }
}
