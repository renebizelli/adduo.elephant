using adduo.elephant.domain.contracts.repositories;
using adduo.elephant.domain.entities;
using adduo.elephant.domain.requests;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace adduo.elephant.repositories.access
{
    public class SpreadSheetRepository : ISpreadSheetRepository
    {
        private readonly ElephantContext context;

        public SpreadSheetRepository(ElephantContext elephantContext)
        {
            this.context = elephantContext;
        }

        public async Task<SpreadSheet> GetAsync(PeriodRequest request)
        {
            return await context.Set<SpreadSheet>()
                .Include("Items.Debt.InCome")
                .Include("Items.Debt.Category")
                .AsSplitQuery()
                .FirstOrDefaultAsync(f => f.Year.Equals(request.Year) && f.Month.Equals(request.Month));
        }

        public async Task SaveAsync(SpreadSheet spreadSheet)
        {
            await context.Set<SpreadSheet>().AddAsync(spreadSheet);
        }
    }
}
