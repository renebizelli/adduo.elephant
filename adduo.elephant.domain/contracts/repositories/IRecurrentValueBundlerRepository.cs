using adduo.elephant.domain.entities.debts.bundler_items;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.repositories
{
    public interface IRecurrentValueBundlerRepository
    {
        Task AddValueAsync(Guid recurrentId, RecurrentBundlerValue value);
        void UpdateValue(RecurrentBundlerValue value);
        Task<RecurrentBundlerValue> GetAsync(Guid recurrentId, int valueId);
    }
}
