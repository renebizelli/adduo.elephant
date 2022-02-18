using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.mappers.debts.items;
using adduo.elephant.domain.requests.debts.items;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace adduo.elephant.test.services.debts.items
{
    public class MonthlyBundlerServiceTest : DebtServiceTest<MonthlyBundlerRequest, MonthlyBundler, MonthlyBundlerProfile>
    {
        [Fact]
        public async Task ShoudCallMethodsWhenCallSave()
        {
            var request = new Mock<MonthlyBundlerRequest>();
            request.Object.Tags = new utilities.entries.ListEntry<int>();

            await base.ShoudCallMethodsWhenCallSaveBase(request);
        }
    }
}
