using adduo.elephant.domain.entities.debts_template;
using System;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.repositories
{
    public interface IDebtTemplateRepository<T> where T : DebtTemplate
    {
        Task SaveAsync(T entity);
        void Update(T entity);
        Task<T> GetAsync(Guid guid);
    }
}
