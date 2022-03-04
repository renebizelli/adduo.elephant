using adduo.elephant.domain.requests.debts.bundler_items;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.services
{
    public interface IRecurrenteValueService
    {
        Task<RecurrentValueRequest> AddValueAsync(string id, RecurrentValueRequest value);
    }
}
