using adduo.elephant.domain.entities.debts;
using System;
using System.Threading.Tasks;
using Xunit;

namespace adduo.elephant.test.repositories
{
    public class MonthlyRecurrenceItemDebtRepositoryTest : BaseRepositoryTest<MonthlyRecurrenceItemDebt>
    {
        [Fact]
        public async Task ShoudSaveDebtOnDb()
        {
            var debt = new MonthlyRecurrenceItemDebt(Guid.NewGuid(), "teste", 1, 2, 3);

            await this.SaveAsyncTest(debt);
        }
    }
}
