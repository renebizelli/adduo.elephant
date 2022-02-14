using adduo.elephant.domain.entities.debts;
using System;
using System.Threading.Tasks;
using Xunit;

namespace adduo.elephant.test.repositories
{
    public class YearlyRecurrenceItemDebtRepositoryTest : BaseRepositoryTest<YearlyRecurrenceItemDebt>
    {
        [Fact]
        public async Task ShoudSaveDebtOnDb()
        {
            var debt = new YearlyRecurrenceItemDebt(Guid.NewGuid(), "teste", 1, 2, 3, 3);

            await this.SaveAsyncTest(debt);
        }
    }
}
