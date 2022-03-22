using adduo.elephant.domain.entities.debts_template;
using adduo.elephant.domain.requests.debts_template;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.services
{
    public interface IDebtTemplateService<TRequest, TEntity> 
        where TRequest : DebtTemplateRequest
        where TEntity : DebtTemplate
    {
        Task<TRequest> SaveAsync(TRequest debt);
        Task<TRequest> UpdateAsync(string id, TRequest debt);
    }
}
