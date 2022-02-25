using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.mappers.debts.items;
using adduo.elephant.domain.requests.debts.items;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace adduo.elephant.test.services.debts.items
{
    public class MonthlyServiceTest : DebtServiceTest<MonthlyRequest, Monthly, MonthlyProfile>
    {
        [Fact]
        public async Task ShoudCallMethodsWhenCallSave()
        {
            var request = new Mock<MonthlyRequest>();
            request.Object.CategoryId = new utilities.entries.IntEntry();

            await base.ShoudCallMethodsWhenCallSaveBase(request);
        }

        [Fact]
        public async Task ShoudCallMethodsWhenCallUpdate()
        {
            var request = new Mock<MonthlyRequest>();
            request.Object.CategoryId = new utilities.entries.IntEntry();

            await base.ShoudCallMethodsWhenCallUpdateBase(Guid.NewGuid().ToString(), request);
        }

        [Fact]
        public async Task ShoudUpdateEntity()
        {
            var installment = await context.Set<Monthly>().FirstAsync();

            var request = HelperDebtItemsTest.CreateMonthlyRequest(
                "Teste trocado",
                DateTime.Now.Millisecond,
                DateTime.Now.Day,
                3,
                DateTime.Now.Millisecond);

            await base.ShoudUpdateEntityBase(installment.Id.ToString(), request);

            var entity = await context.Set<Monthly>().Include(i => i.Category).FirstAsync(f => f.Id == installment.Id);

            DebtAssert(request, entity);
            ItemAssert(request, entity);
            ItemAmountAssert(request, entity);
        }
    }
}
