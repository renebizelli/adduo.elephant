using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.mappers;
using adduo.elephant.domain.requests;
using adduo.elephant.test.requests;
using AutoMapper;
using Xunit;

namespace adduo.elephant.test.mappers
{
    public class MapperConfigurationTest
    {
        private MapperConfiguration configuration;

        public MapperConfigurationTest()
        {
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DebtProfile());
                cfg.AddProfile(new ItemDebtProfile());
                cfg.AddProfile(new PontualItemDebtProfile());
                cfg.AddProfile(new MonthlyRecurrenceItemDebtProfile());
                cfg.AddProfile(new YearlyRecurrenceItemDebtProfile());
                cfg.AddProfile(new InstallmentsItemDebtProfile());
            });
        }

        [Fact]
        public void MappingTest()
        {
            configuration.AssertConfigurationIsValid();
        }
    }
}
