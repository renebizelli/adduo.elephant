using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.mappers.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace adduo.elephant.test.services.debts.bundler_items
{
    public class RecurrentServiceTest : DebtServiceTest<RecurrentSaveRequest, RecurrentUpdateRequest, Recurrent, RecurrentSaveProfile>
    {
        [Fact]
        public async Task ShoudCallMethodsWhenCallSave()
        {
            var request = new Mock<RecurrentSaveRequest>();
            request.Object.CategoryId = new utilities.entries.IntEntry();
            request.Object.Value = new utilities.entries.DecimalEntry();
            request.Object.Description = new utilities.entries.String64Entry();

            await base.ShoudCallMethodsWhenCallSaveBase(request);
        }


        [Fact]
        public async Task ShoudCallMethodsWhenCallUpdate()
        {
            var request = new Mock<RecurrentUpdateRequest>();
            request.Object.CategoryId = new utilities.entries.IntEntry();

            await base.ShoudCallMethodsWhenCallUpdateBase(Guid.NewGuid().ToString(), request);
        }

        [Fact]
        public async Task ShoudUpdateEntity()
        {
            var Recurrent = await context.Set<Recurrent>().FirstAsync();

            var request = HelperDebtBundlerItemsTest.CreateRecurrentUpdateRequest(
                "Teste trocado",
                3,
                Guid.NewGuid());

            await base.ShoudUpdateEntityBase(Recurrent.Id.ToString(), request);

            var entity = await context.Set<Recurrent>().Include(i => i.Category).FirstAsync(f => f.Id == Recurrent.Id);

            DebtAssert(request, entity);
            ItemAssert(request, entity);
        }
    }
}
