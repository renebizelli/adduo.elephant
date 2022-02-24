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
                new System.Collections.Generic.List<int> { 1, 2 },
                DateTime.Now.Month,
                DateTime.Now.Year,
                Guid.NewGuid());

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.VALID, request.Month.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Year.Status);

            base.ShouldBeOkAndValidStatusDebt(request);
            base.ShouldBeOkAndValidStatusItem(request);
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
        }
    }
}
