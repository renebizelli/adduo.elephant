using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.mappers.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using adduo.elephant.test.services.debts.items;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace adduo.elephant.test.services.debts.bundler_items
{
    public class PontualServiceTest : DebtServiceTest<PontualRequest, Pontual, PontualProfile>
    {
        [Fact]
        public async Task ShoudCallMethodsWhenCallSave()
        {
            var request = new Mock<PontualRequest>();
            request.Object.Tags = new utilities.entries.ListEntry<int>();

            await base.ShoudCallMethodsWhenCallSaveBase(request);
        }

        [Fact]
        public async Task ShoudCallMethodsWhenCallUpdate()
        {
            var request = new Mock<PontualRequest>();
            request.Object.Tags = new utilities.entries.ListEntry<int>();

            await base.ShoudCallMethodsWhenCallUpdateBase(Guid.NewGuid().ToString(), request);
        }

        [Fact]
        public async Task ShoudUpdateEntity()
        {
            var Pontual = await context.Set<Pontual>().FirstAsync();

            var request = HelperDebtBundlerItemsTest.CreatePontualRequest(
                "Teste trocado",
                DateTime.Now.Millisecond,
                new List<int> { 3 },
                DateTime.Now.Month,
                DateTime.Now.Year,
                Guid.NewGuid());

            await base.ShoudUpdateEntityBase(Pontual.Id.ToString(), request);

            var entity = await context.Set<Pontual>().Include(i => i.Tags).FirstAsync(f => f.Id == Pontual.Id);

            Assert.Equal(request.Month.GetValue(), entity.Month);
            Assert.Equal(request.Year.GetValue(), entity.Year);

            DebtAssert(request, entity);
            ItemAssert(request, entity);
        }
    }
}
