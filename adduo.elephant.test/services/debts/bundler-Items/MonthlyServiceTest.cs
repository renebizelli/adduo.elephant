using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.mappers.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
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

        [Fact]
        public async Task ShoudCallMethodsWhenCallUpdate()
        {
            var request = new Mock<MonthlyRequest>();
            request.Object.Tags = new utilities.entries.ListEntry<int>();

            await base.ShoudCallMethodsWhenCallUpdateBase(Guid.NewGuid().ToString(), request);
        }

        [Fact]
        public async Task ShoudUpdateEntity()
        {
            var Monthly = await context.Set<Monthly>().FirstAsync();

            var request = HelperDebtBundlerItemsTest.CreateMonthlyRequest(
                "Teste trocado",
                DateTime.Now.Millisecond,
                new List<int> { 3 },
                Guid.NewGuid());

            await base.ShoudUpdateEntityBase(Monthly.Id.ToString(), request);

            var entity = await context.Set<Monthly>().Include(i => i.Tags).FirstAsync(f => f.Id == Monthly.Id);

            DebtAssert(request, entity);
            ItemAssert(request, entity);
        }
    }
}
