using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.requests;
using adduo.elephant.domain.requests.debts.bundler_items;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts.bundler_items
{
    public class ItemProfile : Profile
    {
        public ItemProfile()  
        {
            CreateMap<ItemRequest, Item>()
                .IncludeBase<DebtRequest, Debt>()
                .ForMember(d => d.BundlerMonthly, a => a.Ignore())
                .ForMember(d => d.BundlerMonthlyId, a => a.MapFrom(src => src.BundlerMonthly.GetValue()));
        }
    }
}

