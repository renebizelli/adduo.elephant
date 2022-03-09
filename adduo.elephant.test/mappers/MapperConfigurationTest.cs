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
                cfg.AddProfile(new domain.mappers.debts.items.BundlerMonthlyProfile());

                cfg.AddProfile(new domain.mappers.debts.bundler_items.ItemBundlerProfile());
                cfg.AddProfile(new domain.mappers.debts.bundler_items.ItemAmountBundlerProfile());
                cfg.AddProfile(new domain.mappers.debts.bundler_items.PontualBundlerProfile());
                cfg.AddProfile(new domain.mappers.debts.bundler_items.InstallmentBundlerProfile());
                cfg.AddProfile(new domain.mappers.debts.bundler_items.MonthlyBundlerProfile());
                cfg.AddProfile(new domain.mappers.debts.bundler_items.YearlyBundlerProfile());
                cfg.AddProfile(new domain.mappers.debts.bundler_items.RecurrentBundlerSaveProfile());
                cfg.AddProfile(new domain.mappers.debts.bundler_items.RecurrentBundlerUpdateProfile());
                cfg.AddProfile(new domain.mappers.debts.bundler_items.RecurrentValueBundlerProfile());

                cfg.AddProfile(new domain.mappers.SpreadSheetProfile());
            });
        }

        [Fact]
        public void MappingTest()
        {
            configuration.AssertConfigurationIsValid();
        }
    }
}
