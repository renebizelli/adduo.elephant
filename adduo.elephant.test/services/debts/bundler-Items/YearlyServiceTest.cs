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
    public class YearlyServiceTest : DebtServiceTest<YearlyRequest, Yearly, YearlyProfile>
    {
        [Fact]
        public async Task ShoudCallMethodsWhenCallSave()
        {
            var request = new Mock<YearlyRequest>();
            request.Object.CategoryId = new utilities.entries.IntEntry();

            await base.ShoudCallMethodsWhenCallSaveBase(request);
        }

        [Fact]
        public async Task ShoudCallMethodsWhenCallUpdate()
        {
            var request = new Mock<YearlyRequest>();
            request.Object.CategoryId = new utilities.entries.IntEntry();

            await base.ShoudCallMethodsWhenCallUpdateBase(Guid.NewGuid().ToString(), request);
        }

        [Fact]
        public async Task ShoudUpdateEntity()
        {
            var Yearly = await context.Set<Yearly>().FirstAsync();

            var request = HelperDebtBundlerItemsTest.CreateYearlyRequest(
                "Teste trocado",
                DateTime.Now.Millisecond,
                3,
                DateTime.Now.Month,
                Guid.NewGuid());

            await base.ShoudUpdateEntityBase(Yearly.Id.ToString(), request);

            var entity = await context.Set<Yearly>().Include(i => i.Category).FirstAsync(f => f.Id == Yearly.Id);

            Assert.Equal(request.DueMonth.GetValue(), entity.DueMonth);

            DebtAssert(request, entity);
            ItemAssert(request, entity);
            ItemAmountAssert(request, entity);
        }
    }
}
