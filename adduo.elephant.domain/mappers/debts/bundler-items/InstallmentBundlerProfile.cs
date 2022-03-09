using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts.bundler_items
{
    public class InstallmentBundlerProfile : Profile
    {
        public InstallmentBundlerProfile()  
        {
            CreateMap<InstallmentBundlerRequest, InstallmentBundler>()
                .IncludeBase<ItemAmountBundlerRequest, ItemAmountBundler>()
                .ForMember(d => d.StartMonth, a => a.MapFrom(src => src.StartMonth.GetValue()))
                .ForMember(d => d.StartYear, a => a.MapFrom(src => src.StartYear.GetValue()))
                .ForMember(d => d.Installments, a => a.MapFrom(src => src.Installments.GetValue()));
        }
    }
}

