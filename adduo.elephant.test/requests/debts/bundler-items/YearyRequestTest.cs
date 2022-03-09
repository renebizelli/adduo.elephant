using adduo.elephant.domain.requests.debts.bundler_items;
using System;
using Xunit;

namespace adduo.elephant.test.requests.debts.bundler_items
{
    public class YearyRequestTest : ItemRequestTest
    {
        [Fact]
        public void ValidRequest()
        {
            var request = HelperDebtBundlerItemsTest.CreateYearlyRequest(
                            "René Bizelli",
                            DateTime.Now.Millisecond,
                            1,
                            DateTime.Now.Month,
                            Guid.NewGuid());

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.VALID, request.DueMonth.Status);

            base.ShouldBeOkAndValidStatusDebt(request);
            base.ShouldBeOkAndValidStatusItem(request);
            base.ShouldBeOkAndValidStatusItemAmountRequest(request);
        }

        [Fact]
        public void InvalidRequest()
        {
            var request = new YearlyBundlerRequest();

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.INVALID, request.DueMonth.Status);

            base.ShouldBeBadRequestAndInvalidStatusDebt(request);
            base.ShouldBeBadRequestAndInvalidStatusItemRequest(request);
            base.ShouldBeBadRequestAndInvalidStatusItemAmountRequest(request);
        }
    }
}
