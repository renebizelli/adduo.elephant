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
    public class InstallmentServiceTest : DebtServiceTest<InstallmentRequest, Installment, InstallmentProfile>
    {
        public InstallmentServiceTest()
        {
        }

        [Fact]
        public async Task ShoudCallMethodsWhenCallSave()
        {
            var request = new Mock<InstallmentRequest>();
            request.Object.Tags = new utilities.entries.ListEntry<int>();

            await base.ShoudCallMethodsWhenCallSaveBase(request);
        }

        [Fact]
        public async Task ShoudCallMethodsWhenCallUpdate()
        {
            var request = new Mock<InstallmentRequest>();
            request.Object.Tags = new utilities.entries.ListEntry<int>();

            await base.ShoudCallMethodsWhenCallUpdateBase(Guid.NewGuid().ToString(), request);
        }

        [Fact]
        public async Task ShoudUpdateEntity()
        {
            var installment = await context.Set<Installment>().FirstAsync();

            var request = HelperDebtItemsTest.CreateInstallmentRequest(
                "Teste trocado",
                DateTime.Now.Millisecond,
                DateTime.Now.Day,
                new List<int> { 3 },
                DateTime.Now.Millisecond,
                DateTime.Now.Month,
                DateTime.Now.Year,
                DateTime.Now.Second + 1);

            await base.ShoudUpdateEntityBase(installment.Id.ToString(), request);

            var entity = await context.Set<Installment>().Include(i => i.Tags).FirstAsync(f => f.Id == installment.Id);

            Assert.Equal(request.StartMonth.GetValue(), entity.StartMonth);
            Assert.Equal(request.StartYear.GetValue(), entity.StartYear);

            DebtAssert(request, entity);
            ItemAssert(request, entity);
            ItemAmountAssert(request, entity);
        }

    }
}
