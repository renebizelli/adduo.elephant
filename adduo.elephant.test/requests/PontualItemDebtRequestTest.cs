using adduo.elephant.domain.requests;

using Xunit;

namespace adduo.elephant.test.requests
{
    public class PontualItemDebtRequestTest
    {
        [Fact]
        public void ValidRequest()
        {
            var request = GenerateValidRequest();

            request.Validate();

            Assert.Equal(System.Net.HttpStatusCode.OK, request.HttpStatusCode);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Name.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.DueDay.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.InComeId.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Month.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Year.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Value.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Tags.Status);

        }

        [Fact]
        public void InvalidRequest()
        {
            var request = new PontualItemDebtRequest();

            request.Name = new utilities.entries.NameEntry();
            request.DueDay = new utilities.entries.DayEntry();
            request.InComeId = new utilities.entries.IntEntry();
            request.Tags = new utilities.entries.ListEntry<int>();
            request.Month = new utilities.entries.MonthEntry();
            request.Year = new utilities.entries.IntEntry();
            request.Value = new utilities.entries.DecimalEntry();

            request.Validate();

            Assert.Equal(System.Net.HttpStatusCode.BadRequest, request.HttpStatusCode);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Name.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.DueDay.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.InComeId.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Month.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Year.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Value.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Tags.Status);
        }


        public static PontualItemDebtRequest GenerateValidRequest()
        {
            var request = new PontualItemDebtRequest();

            request.Name = new utilities.entries.NameEntry() { Value = "René" };
            request.DueDay = new utilities.entries.DayEntry { Value = "10" };
            request.InComeId = new utilities.entries.IntEntry { Value = "10" };
            request.Tags = new utilities.entries.ListEntry<int> { Value = new System.Collections.Generic.List<int> { 1, 2 } };
            request.Month = new utilities.entries.MonthEntry { Value = "10" };
            request.Year = new utilities.entries.IntEntry { Value = "2022" };
            request.Value = new utilities.entries.DecimalEntry { Value = "10.89" };

            return request;
        }
    }
}
