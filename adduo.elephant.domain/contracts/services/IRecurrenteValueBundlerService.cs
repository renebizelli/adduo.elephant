using adduo.elephant.domain.requests.debts.bundler_items;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.services
{
    public interface IRecurrenteValueBundlerService
    {
        Task<RecurrentValueBundlerRequest> AddValueAsync(string id, RecurrentValueBundlerRequest value);
        Task<RecurrentValueBundlerRequest> UpdateValueAsync(string recurrentId, string valueId, RecurrentValueBundlerRequest request);

    }
}
