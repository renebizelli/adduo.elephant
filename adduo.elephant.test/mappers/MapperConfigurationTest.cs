using adduo.elephant.domain.mappers.debts;
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
                cfg.AddProfile(new domain.mappers.debts.items.ItemProfile());
                cfg.AddProfile(new domain.mappers.debts.items.ItemAmountProfile());
                cfg.AddProfile(new domain.mappers.debts.items.PontualProfile());
                cfg.AddProfile(new domain.mappers.debts.items.MonthlyProfile());
                cfg.AddProfile(new domain.mappers.debts.items.YearlyProfile());
                cfg.AddProfile(new domain.mappers.debts.items.InstallmentProfile());
                cfg.AddProfile(new domain.mappers.debts.items.MonthlyBundlerProfile());

                cfg.AddProfile(new domain.mappers.debts.bundler_items.ItemProfile());
                cfg.AddProfile(new domain.mappers.debts.bundler_items.ItemAmountProfile());
                cfg.AddProfile(new domain.mappers.debts.bundler_items.PontualProfile());
                cfg.AddProfile(new domain.mappers.debts.bundler_items.InstallmentProfile());
                cfg.AddProfile(new domain.mappers.debts.bundler_items.MonthlyProfile());
                cfg.AddProfile(new domain.mappers.debts.bundler_items.YearlyProfile());
            });
        }

        [Fact]
        public void MappingTest()
        {
            configuration.AssertConfigurationIsValid();
        }
    }
}
