using adduo.elephant.domain.requests;
using adduo.elephant.domain.requests.debts.items;
using Xunit;

namespace adduo.elephant.test.requests.debts.items
{
    public class ItemRequestTest
    {
        public void ShouldBeOkAndValidStatusDebt(DebtRequest request)
        {
            Assert.Equal(System.Net.HttpStatusCode.OK, request.HttpStatusCode);

            Assert.Equal(utilities.entries.StatusCode.VALID, request.Name.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.CategoryId.Status);
        }

        public void ShouldBeOkAndValidStatusItem(ItemRequest request)
        {
            Assert.Equal(System.Net.HttpStatusCode.OK, request.HttpStatusCode);
            
            Assert.Equal(utilities.entries.StatusCode.VALID, request.DueDayOfMonth.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.InComeId.Status);
        }

        public void ShouldBeOkAndValidStatusItemAmount(ItemAmountRequest request)
        {
            Assert.Equal(System.Net.HttpStatusCode.OK, request.HttpStatusCode);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Value.Status);
        }

        public void ShouldBeBadRequestAndInvalidStatusDebt(DebtRequest request)
        {
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, request.HttpStatusCode);

            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Name.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.CategoryId.Status);
        }

        public void ShouldBeBadRequestAndInvalidStatusItemRequest(ItemRequest request)
        {
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, request.HttpStatusCode);

            Assert.Equal(utilities.entries.StatusCode.INVALID, request.DueDayOfMonth.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.InComeId.Status);
        }

        public void ShouldBeBadRequestAndInvalidStatusItemAmountRequest(ItemAmountRequest request)
        {
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, request.HttpStatusCode);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Value.Status);
        }

    }
}
