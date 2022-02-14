using adduo.elephant.domain.requests;
using System;
using Xunit;

namespace adduo.elephant.test.requests
{
    public class YearyRecurrenceItemDebtRequestTest : BaseItemDebtRequestTest
    {
        [Fact]
        public void ValidRequest()
        {
            var request = HelperTest.CreateYearlyRecurrenceItemDebtRequest(
                            "René Bizelli",
                            DateTime.Now.Millisecond,
                            DateTime.Now.Day,
                            new System.Collections.Generic.List<int> { 1, 2 },
                            1,
                            DateTime.Now.Month);

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.VALID, request.DueMonth.Status);

            base.ShouldBeOkAndValidStatus(request);
        }

        [Fact]
        public void InvalidRequest()
        {
            var request = new YearlyRecurrenceItemDebtRequest();

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.INVALID, request.DueMonth.Status);

            base.ShouldBeBadRequestAndInvalidStatus(request);
        }
    }
}
