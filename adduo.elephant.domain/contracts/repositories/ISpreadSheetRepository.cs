using adduo.elephant.domain.entities;
using adduo.elephant.domain.requests;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.repositories
{
    public interface ISpreadSheetRepository
    {
        Task<SpreadSheet> GetAsync(PeriodRequest request);
        Task SaveAsync(SpreadSheet spreadSheet);
    }
}
