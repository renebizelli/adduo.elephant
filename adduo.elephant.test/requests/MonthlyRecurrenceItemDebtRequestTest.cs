using adduo.elephant.domain.requests;
using System;
using Xunit;

namespace adduo.elephant.test.requests
{
    public class MonthlyRecurrenceItemDebtRequestTest : BaseItemDebtRequestTest
    {
        [Fact]
        public void ValidRequest()
        {
            var request = HelperTest.CreateMonthlyRecurrenceItemDebtRequest(
                            "René Bizelli",
                            DateTime.Now.Millisecond,
                            DateTime.Now.Day,
                            new System.Collections.Generic.List<int> { 1, 2 },
                            1);

            request.Validate();

            base.ShouldBeOkAndValidStatus(request);
        }

        [Fact]
        public void InvalidRequest()
        {
            var request = new MonthlyRecurrenceItemDebtRequest();

            request.Validate();

            base.ShouldBeBadRequestAndInvalidStatus(request);
        }
    }
}
