using adduo.elephant.domain.entities.debts;
using System;
using System.Threading.Tasks;
using Xunit;

namespace adduo.elephant.test.repositories
{
    public class InstallmentsItemDebtRepositoryTest : BaseRepositoryTest<InstallmentsItemDebt>
    {
        [Fact]
        public async Task ShoudSaveDebtOnDb()
        {
            var debt = new InstallmentsItemDebt(Guid.NewGuid(), "teste", 1, 2, 3, 3, 2020, 3);

            await this.SaveAsyncTest(debt);
        }
    }
}
