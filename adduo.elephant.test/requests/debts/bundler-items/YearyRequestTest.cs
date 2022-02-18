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
                            new System.Collections.Generic.List<int> { 1, 2 },
                            DateTime.Now.Month);

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.VALID, request.DueMonth.Status);

            base.ShouldBeOkAndValidStatusDebt(request);
            base.ShouldBeOkAndValidStatusItem(request);
        }

        [Fact]
        public void InvalidRequest()
        {
            var request = new YearlyRequest();

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.INVALID, request.DueMonth.Status);

            base.ShouldBeBadRequestAndInvalidStatusDebt(request);
            base.ShouldBeBadRequestAndInvalidStatusItemRequest(request);
        }
    }
}
