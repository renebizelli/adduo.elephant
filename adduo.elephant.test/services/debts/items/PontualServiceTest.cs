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
    public class PontualServiceTest : DebtServiceTest<PontualRequest, Pontual, PontualProfile>
    {
        [Fact]
        public async Task ShoudCallMethodsWhenCallSave()
        {
            var request = new Mock<PontualRequest>();
            request.Object.CategoryId = new utilities.entries.IntEntry();

            await base.ShoudCallMethodsWhenCallSaveBase(request);
        }

        [Fact]
        public async Task ShoudCallMethodsWhenCallUpdate()
        {
            var request = new Mock<PontualRequest>();
            request.Object.CategoryId = new utilities.entries.IntEntry();

            await base.ShoudCallMethodsWhenCallUpdateBase(Guid.NewGuid().ToString(), request);
        }

        [Fact]
        public async Task ShoudUpdateEntity()
        {
            var installment = await context.Set<Pontual>().FirstAsync();

            var request = HelperDebtItemsTest.CreatePontualRequest(
                "Teste trocado",
                DateTime.Now.Millisecond,
                DateTime.Now.Day,
                3,
                DateTime.Now.Millisecond,
                DateTime.Now.Month,
                DateTime.Now.Year);

            await base.ShoudUpdateEntityBase(installment.Id.ToString(), request);

            var entity = await context.Set<Pontual>().Include(i => i.Category).FirstAsync(f => f.Id == installment.Id);

            Assert.Equal(request.Month.GetValue(), entity.Month);
            Assert.Equal(request.Year.GetValue(), entity.Year);

            DebtAssert(request, entity);
            ItemAssert(request, entity);
            ItemAmountAssert(request, entity);
        }

    }
}
