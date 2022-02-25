using adduo.elephant.domain.requests.debts.items;
using System;
using Xunit;

namespace adduo.elephant.test.requests.debts.items
{
    public class PontualRequestTest : ItemRequestTest
    {
        [Fact]
        public void ValidRequest()
        {
            var request = HelperDebtItemsTest.CreatePontualRequest(
                "René Bizelli",
                DateTime.Now.Millisecond,
                DateTime.Now.Day,
                1,
                1,
                DateTime.Now.Month,
                DateTime.Now.Year);

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.VALID, request.Month.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Year.Status);

            base.ShouldBeOkAndValidStatusDebt(request);
            base.ShouldBeOkAndValidStatusItem(request);
            base.ShouldBeOkAndValidStatusItemAmount(request);
        }

        [Fact]
        public void InvalidRequest()
        {
            var request = new PontualRequest();

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Month.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Year.Status);

            base.ShouldBeBadRequestAndInvalidStatusDebt(request);
            base.ShouldBeBadRequestAndInvalidStatusItemRequest(request);
            base.ShouldBeBadRequestAndInvalidStatusItemAmountRequest(request);
        }
    }
}
