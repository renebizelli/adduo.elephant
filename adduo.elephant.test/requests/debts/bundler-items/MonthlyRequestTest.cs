using adduo.elephant.domain.requests.debts.bundler_items;
using System;
using Xunit;

namespace adduo.elephant.test.requests.debts.bundler_items
{
    public class MonthlyRequestTest : ItemRequestTest
    {
        [Fact]
        public void ValidRequest()
        {
            var request = HelperDebtBundlerItemsTest.CreateMonthlyRequest(
                            "René Bizelli",
                            DateTime.Now.Millisecond,
                            1,
                            Guid.NewGuid());
                            

            request.Validate();

            base.ShouldBeOkAndValidStatusDebt(request);
            base.ShouldBeOkAndValidStatusItem(request);
            base.ShouldBeOkAndValidStatusItemAmountRequest(request);
        }

        [Fact]
        public void InvalidRequest()
        {
            var request = new MonthlyBundlerRequest();

            request.Validate();

            base.ShouldBeBadRequestAndInvalidStatusDebt(request);
            base.ShouldBeBadRequestAndInvalidStatusItemRequest(request);
            base.ShouldBeBadRequestAndInvalidStatusItemAmountRequest(request);
        }
    }
}
