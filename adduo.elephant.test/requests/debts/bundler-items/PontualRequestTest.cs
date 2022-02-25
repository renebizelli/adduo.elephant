using adduo.elephant.domain.requests.debts.bundler_items;
using System;
using Xunit;

namespace adduo.elephant.test.requests.debts.bundler_items
{
    public class PontualRequestTest : ItemRequestTest
    {
        [Fact]
        public void ValidRequest()
        {
            var request = HelperDebtBundlerItemsTest.CreatePontualRequest(
                "René Bizelli",
                DateTime.Now.Millisecond,
                1,
                DateTime.Now.Month,
                DateTime.Now.Year,
                Guid.NewGuid());

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.VALID, request.Month.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Year.Status);

            base.ShouldBeOkAndValidStatusDebt(request);
            base.ShouldBeOkAndValidStatusItem(request);
            base.ShouldBeOkAndValidStatusItemAmountRequest(request);
        }

        [Fact]
        public void InvalidRequest()
        {
            var request = new PontualRequest();

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Month.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Year.Status);

            base.ShouldBeBadRequestAndInvalidStatusDebt(request);
            base.ShouldBeBadRequestAndInvalidStatusItemAmountRequest(request);
        }
    }
}
