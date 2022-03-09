using adduo.elephant.domain.entities;
using adduo.elephant.domain.requests;
using System.Threading.Tasks;

namespace adduo.elephant.domain.contracts.services
{
    public interface ISpreadSheetService
    {
        Task<dtos.SpreadSheet> GetAsync(PeriodRequest periodRequest);
    }
}
