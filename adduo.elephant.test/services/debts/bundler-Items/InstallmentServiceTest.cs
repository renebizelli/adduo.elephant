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
    public class InstallmentServiceTest : DebtServiceTest<InstallmentRequest, Installment, InstallmentProfile>
    {
        [Fact]
        public async Task ShoudCallMethodsWhenCallSave()
        {
            var request = new Mock<InstallmentRequest>();
            request.Object.CategoryId = new utilities.entries.IntEntry();

            await base.ShoudCallMethodsWhenCallSaveBase(request);
        }


        [Fact]
        public async Task ShoudCallMethodsWhenCallUpdate()
        {
            var request = new Mock<InstallmentRequest>();
            request.Object.CategoryId = new utilities.entries.IntEntry();

            await base.ShoudCallMethodsWhenCallUpdateBase(Guid.NewGuid().ToString(), request);
        }

        [Fact]
        public async Task ShoudUpdateEntity()
        {
            var installment = await context.Set<Installment>().FirstAsync();

            var request = HelperDebtBundlerItemsTest.CreateInstallmentRequest(
                "Teste trocado",
                DateTime.Now.Millisecond,
                3,
                DateTime.Now.Month,
                DateTime.Now.Year,
                DateTime.Now.Second + 1,
                Guid.NewGuid());

            await base.ShoudUpdateEntityBase(installment.Id.ToString(), request);

            var entity = await context.Set<Installment>().Include(i => i.Category).FirstAsync(f => f.Id == installment.Id);

            Assert.Equal(request.StartMonth.GetValue(), entity.StartMonth);
            Assert.Equal(request.StartYear.GetValue(), entity.StartYear);

            DebtAssert(request, entity);
            ItemAssert(request, entity);
            ItemAmountAssert(request, entity);
        }
    }
}
