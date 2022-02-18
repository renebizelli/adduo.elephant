using adduo.elephant.domain.entities.debts;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.repositories
{
    public interface IDebtRepository<T> where T : Debt
    {
        Task SaveAsync(T entity);
        void Update(T entity);
    }
}
