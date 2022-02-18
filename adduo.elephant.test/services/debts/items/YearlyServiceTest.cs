using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.mappers.debts.items;
using adduo.elephant.domain.requests.debts.items;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace adduo.elephant.test.services.debts.items
{
    public class YearlyServiceTest : DebtServiceTest<YearlyRequest, Yearly, YearlyProfile>
    {
        [Fact]
        public async Task ShoudCallMethodsWhenCallSave()
        {
            var request = new Mock<YearlyRequest>();
            request.Object.Tags = new utilities.entries.ListEntry<int>();

            await base.ShoudCallMethodsWhenCallSaveBase(request);
        }
    }
}
