using adduo.elephant.domain.requests.debts.bundler_items;
using System;
using Xunit;

namespace adduo.elephant.test.requests.debts.bundler_items
{
    public class RecurrentRequestTest : ItemRequestTest
    {
        [Fact]
        public void ValidRequest()
        {
            var request = HelperDebtBundlerItemsTest.CreateRecurrentSaveRequest(
                            "debt",
                            "description",
                            DateTime.Now.Millisecond,
                            1,
                            Guid.NewGuid());

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.VALID, request.Value.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Description.Status);

            base.ShouldBeOkAndValidStatusDebt(request);
            base.ShouldBeOkAndValidStatusItem(request);
        }

        [Fact]
        public void InvalidRequest()
        {
            var request = new RecurrentSaveRequest();

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Value.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Description.Status);

            base.ShouldBeBadRequestAndInvalidStatusDebt(request);
            base.ShouldBeBadRequestAndInvalidStatusItemRequest(request);
        }
    }
}
