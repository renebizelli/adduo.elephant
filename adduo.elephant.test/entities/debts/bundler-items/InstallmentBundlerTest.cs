using adduo.elephant.domain.entities.debts.bundler_items;
using System;
using Xunit;

namespace adduo.elephant.test.entities.debts.bundler_items
{
    public class InstallmentBundlerTest
    {
        [Theory]
        [InlineData(2020, 1, 202001)]
        [InlineData(2021, 1, 202101)]
        [InlineData(2022, 12, 202212)]
        public void ValidStartPeriodProperty(int year, int month, int expected)
        {
            var entity = new InstallmentBundler(Guid.NewGuid(), string.Empty, 0, Guid.NewGuid(), month, year, 0);

            Assert.Equal(expected, entity.StartPeriod);
        }

        [Theory]
        [InlineData(2020, 1, 3, 202003)]
        [InlineData(2021, 3, 10, 202112)]
        [InlineData(2022, 12, 5, 202304)]
        [InlineData(1900, 1, 24, 190112)]
        [InlineData(1900, 1, 25, 190201)]
        public void ValidFinishPeriodProperty(int year, int month, int installment, int expected)
        {
            var entity = new InstallmentBundler(Guid.NewGuid(), string.Empty, 0, Guid.NewGuid(), month, year, installment);

            Assert.Equal(expected, entity.FinishPeriod);
        }
    }

}