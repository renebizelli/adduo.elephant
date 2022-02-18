using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.mappers.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace adduo.elephant.test.services.debts.bundler_items
{
    public class MonthlyServiceTest : DebtServiceTest<MonthlyRequest, Monthly, MonthlyProfile>
    {
        [Fact]
        public async Task ShoudCallMethodsWhenCallSave()
        {
            var request = new Mock<MonthlyRequest>();
            request.Object.Tags = new utilities.entries.ListEntry<int>();

            await base.ShoudCallMethodsWhenCallSaveBase(request);
        }
    }
}
