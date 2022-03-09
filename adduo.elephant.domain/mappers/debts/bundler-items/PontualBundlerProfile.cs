using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts.bundler_items
{
    public class PontualBundlerProfile : Profile
    {
        public PontualBundlerProfile()  
        {
            CreateMap<PontualBundlerRequest, PontualBundler>()
                .IncludeBase<ItemAmountBundlerRequest, ItemAmountBundler>()
                .ForMember(d => d.Month, a => a.MapFrom(src => src.Month.GetValue()))
                .ForMember(d => d.Year, a => a.MapFrom(src => src.Year.GetValue()));
        }
    }
}

