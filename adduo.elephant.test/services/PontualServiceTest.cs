﻿using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.mappers;
using adduo.elephant.domain.requests;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace adduo.elephant.test.services
{
    public class PontualServiceTest : DebtServiceTest<PontualItemDebtRequest, PontualItemDebt, PontualItemDebtProfile>
    {
        [Fact]
        public async Task ShoudCallMethodsWhenCallSave()
        {
            var request = new Mock<PontualItemDebtRequest>();
            request.Object.Tags = new utilities.entries.ListEntry<int>();

            await base.ShoudCallMethodsWhenCallSaveBase(request);
        }
    }
}
