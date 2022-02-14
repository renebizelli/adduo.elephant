using adduo.elephant.domain.entities.debts;
using System;
using System.Threading.Tasks;
using Xunit;

namespace adduo.elephant.test.repositories
{
    public class PontualItemDebtRepositoryTest : BaseRepositoryTest<PontualItemDebt>
    {
        [Fact]
        public async Task ShoudSaveDebtOnDb()
        {
            var debt = new PontualItemDebt(Guid.NewGuid(), "teste", 1, 2, 3, 2020, 5);

            await this.SaveAsyncTest(debt);
        }
    }
}
