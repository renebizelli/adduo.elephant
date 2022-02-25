using adduo.elephant.domain.requests.debts.items;
using System;
using Xunit;

namespace adduo.elephant.test.requests.debts.items
{
    public class YearyRequestTest : ItemRequestTest
    {
        [Fact]
        public void ValidRequest()
        {
            var request = HelperDebtItemsTest.CreateYearlyRequest(
                            "René Bizelli",
                            DateTime.Now.Millisecond,
                            DateTime.Now.Day,
                            1,
                            1,
                            DateTime.Now.Month);

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.VALID, request.DueMonth.Status);

            base.ShouldBeOkAndValidStatusDebt(request);
            base.ShouldBeOkAndValidStatusItem(request);
            base.ShouldBeOkAndValidStatusItemAmount(request);
        }

        [Fact]
        public void InvalidRequest()
        {
            var request = new YearlyRequest();

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.INVALID, request.DueMonth.Status);

            base.ShouldBeBadRequestAndInvalidStatusDebt(request);
            base.ShouldBeBadRequestAndInvalidStatusItemRequest(request);
            base.ShouldBeBadRequestAndInvalidStatusItemAmountRequest(request);
        }
    }
}
