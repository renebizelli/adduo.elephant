using adduo.elephant.domain.requests.debts.items;
using System;
using Xunit;

namespace adduo.elephant.test.requests.debts.items
{
    public class MonthlyBundlerRequestTest : ItemRequestTest
    {
        [Fact]
        public void ValidRequest()
        {
            var request = HelperDebtItemsTest.CreateMonthlyBundlerRequest(
                            "René Bizelli",
                            DateTime.Now.Day,
                            new System.Collections.Generic.List<int> { 1, 2 },
                            1);

            request.Validate();

            base.ShouldBeOkAndValidStatusDebt(request);
            base.ShouldBeOkAndValidStatusItem(request);
        }

        [Fact]
        public void InvalidRequest()
        {
            var request = new MonthlyBundlerRequest();

            request.Validate();

            base.ShouldBeBadRequestAndInvalidStatusDebt(request);
            base.ShouldBeBadRequestAndInvalidStatusItemRequest(request);
        }
    }
}
