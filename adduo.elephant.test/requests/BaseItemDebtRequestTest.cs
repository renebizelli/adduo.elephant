using adduo.elephant.domain.requests;
using adduo.elephant.utilities.entries;
using Xunit;

namespace adduo.elephant.test.requests
{
    public class BaseItemDebtRequestTest
    {
        public void ShouldBeOkAndValidStatus(ItemDebtRequest request)
        {
            Assert.Equal(System.Net.HttpStatusCode.OK, request.HttpStatusCode);
            
            Assert.Equal(utilities.entries.StatusCode.VALID, request.DueDay.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.InComeId.Status);
        }

        public void ShouldBeOkAndValidStatus(DebtRequest request)
        {
            Assert.Equal(System.Net.HttpStatusCode.OK, request.HttpStatusCode);

            Assert.Equal(utilities.entries.StatusCode.VALID, request.Name.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Value.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Tags.Status);
        }

        public void ShouldBeBadRequestAndInvalidStatus(ItemDebtRequest request)
        {
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, request.HttpStatusCode);

            Assert.Equal(utilities.entries.StatusCode.INVALID, request.DueDay.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.InComeId.Status);
        }

        public void ShouldBeBadRequestAndInvalidStatus(DebtRequest request)
        {
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, request.HttpStatusCode);

            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Name.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Value.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Tags.Status);
        }
    }
}
