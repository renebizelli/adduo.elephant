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
                            new System.Collections.Generic.List<int> { 1, 2 },
                            DateTime.Now.Month,
                            2021,
                            3);

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.VALID, request.StartMonth.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.StartYear.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Installments.Status);

            base.ShouldBeOkAndValidStatusDebt(request);
            base.ShouldBeOkAndValidStatusItem(request);
        }

        [Fact]
        public void InvalidRequest()
        {
            var request = new InstallmentRequest();

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.INVALID, request.StartMonth.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.StartYear.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Installments.Status);

            base.ShouldBeBadRequestAndInvalidStatusDebt(request);
            base.ShouldBeBadRequestAndInvalidStatusItemRequest(request);
        }
    }
}
