using adduo.elephant.domain.requests;
using System;
using Xunit;

namespace adduo.elephant.test.requests
{
    public class PontualItemDebtRequestTest : BaseItemDebtRequestTest
    {
        [Fact]
        public void ValidRequest()
        {
            var request = HelperTest.CreatePontualItemDebtRequest(
                "René Bizelli",
                DateTime.Now.Millisecond,
                DateTime.Now.Day,
                new System.Collections.Generic.List<int> { 1, 2 },
                1,
                DateTime.Now.Month,
                DateTime.Now.Year);

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.VALID, request.Month.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Year.Status);

            base.ShouldBeOkAndValidStatus(request);
        }

        [Fact]
        public void InvalidRequest()
        {
            var request = new PontualItemDebtRequest();

            request.Validate();

            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Month.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Year.Status);

            base.ShouldBeBadRequestAndInvalidStatus(request);
        }
    }
}
