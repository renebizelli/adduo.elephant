using adduo.elephant.domain.mappers.debts_template;
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
                cfg.AddProfile(new DebtTemplateProfile());
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
