﻿using adduo.elephant.domain.requests;
using adduo.elephant.domain.requests.debts.bundler_items;
using Xunit;

namespace adduo.elephant.test.requests.debts.bundler_items
{
    public class ItemRequestTest
    {
        public void ShouldBeOkAndValidStatusDebt(DebtRequest request)
        {
            Assert.Equal(System.Net.HttpStatusCode.OK, request.HttpStatusCode);

            Assert.Equal(utilities.entries.StatusCode.VALID, request.Name.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Tags.Status);
        }

        public void ShouldBeOkAndValidStatusItem(ItemRequest request)
        {
            Assert.Equal(System.Net.HttpStatusCode.OK, request.HttpStatusCode);
            
            Assert.Equal(utilities.entries.StatusCode.VALID, request.Value.Status);
            Assert.Equal(utilities.entries.StatusCode.VALID, request.BundlerMonthly.Status);
        }

        public void ShouldBeBadRequestAndInvalidStatusDebt(DebtRequest request)
        {
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, request.HttpStatusCode);

            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Name.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Tags.Status);
        }

        public void ShouldBeBadRequestAndInvalidStatusItemRequest(ItemRequest request)
        {
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, request.HttpStatusCode);

            Assert.Equal(utilities.entries.StatusCode.INVALID, request.Value.Status);
            Assert.Equal(utilities.entries.StatusCode.INVALID, request.BundlerMonthly.Status);
        }
    }
}