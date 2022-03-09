using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts.bundler_items
{
    public class YearlyBundlerProfile : Profile
    {
        public YearlyBundlerProfile() 
        {
            CreateMap<YearlyBundlerRequest, YearlyBundler>()
                .IncludeBase<ItemAmountBundlerRequest, ItemAmountBundler>()
                .ForMember(d => d.DueMonth, a => a.MapFrom(src => src.DueMonth.GetValue()));
        }
    }
}
