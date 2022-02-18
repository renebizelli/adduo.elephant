using adduo.elephant.domain.requests.debts.items;
using System;
using Xunit;

namespace adduo.elephant.test.requests.debts.items
{
    public class MonthlyRequestTest : ItemRequestTest
    {
        [Fact]
        public void ValidRequest()
        {
            var request = HelperDebtItemsTest.CreateMonthlyRequest(
                            "René Bizelli",
                            DateTime.Now.Millisecond,
                            DateTime.Now.Day,
                            new System.Collections.Generic.List<int> { 1, 2 },
                            1);

            request.Validate();

            base.ShouldBeOkAndValidStatusDebt(request);
            base.ShouldBeOkAndValidStatusItem(request);
            base.ShouldBeOkAndValidStatusItemAmount(request);
        }

        [Fact]
        public void InvalidRequest()
        {
            var request = new MonthlyRequest();

            request.Validate();

            base.ShouldBeBadRequestAndInvalidStatusDebt(request);
            base.ShouldBeBadRequestAndInvalidStatusItemRequest(request);
            base.ShouldBeBadRequestAndInvalidStatusItemAmountRequest(request);
        }
    }
}
