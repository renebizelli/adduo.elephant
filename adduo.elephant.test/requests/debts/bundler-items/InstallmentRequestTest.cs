using adduo.elephant.domain.requests.debts.bundler_items;
using System;
using Xunit;

namespace adduo.elephant.test.requests.debts.bundler_items
{
    public class InstallmentRequestTest : ItemRequestTest
    {
        [Fact]
        public void ValidRequest()
        {
            var request = HelperDebtBundlerItemsTest.CreateInstallmentRequest(
                            "René Bizelli",
                            DateTime.Now.Millisecond,
                            1,
                            DateTime.Now.Month,
                            2021,
                            3, 
                            Guid.NewGuid());

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.VALID, request.StartMonth.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.StartYear.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Installments.Status);

            base.ShouldBeOkAndValidStatusDebt(request);
            base.ShouldBeOkAndValidStatusItem(request);
            base.ShouldBeOkAndValidStatusItemAmountRequest(request);
        }

        [Fact]
        public void InvalidRequest()
        {
            var request = new InstallmentBundlerRequest();

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.INVALID, request.StartMonth.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.StartYear.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Installments.Status);

            base.ShouldBeBadRequestAndInvalidStatusDebt(request);
            base.ShouldBeBadRequestAndInvalidStatusItemRequest(request);
            base.ShouldBeBadRequestAndInvalidStatusItemAmountRequest(request);
        }
    }
}
