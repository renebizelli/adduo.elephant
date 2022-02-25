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
    public class MonthlyBundlerServiceTest : DebtServiceTest<MonthlyBundlerRequest, MonthlyBundler, MonthlyBundlerProfile>
    {
        [Fact]
        public async Task ShoudCallMethodsWhenCallSave()
        {
            var request = new Mock<MonthlyBundlerRequest>();
            request.Object.CategoryId = new utilities.entries.IntEntry();

            await base.ShoudCallMethodsWhenCallSaveBase(request);
        }

        [Fact]
        public async Task ShoudCallMethodsWhenCallUpdate()
        {
            var request = new Mock<MonthlyBundlerRequest>();
            request.Object.CategoryId = new utilities.entries.IntEntry();

            await base.ShoudCallMethodsWhenCallUpdateBase(Guid.NewGuid().ToString(), request);
        }


        [Fact]
        public async Task ShoudUpdateEntity()
        {
            var monthlyBundler = await context.Set<MonthlyBundler>().FirstAsync();

            var request = HelperDebtItemsTest.CreateMonthlyBundlerRequest(
                "Teste trocado",
                DateTime.Now.Day,
                3,
                DateTime.Now.Minute);

            await base.ShoudUpdateEntityBase(monthlyBundler.Id.ToString(), request);

            var entity = await context.Set<MonthlyBundler>().Include(i => i.Category).FirstAsync(f => f.Id == monthlyBundler.Id);

            DebtAssert(request, entity);
            ItemAssert(request, entity);
        }
    }
}
