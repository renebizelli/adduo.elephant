using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.requests.debts.items;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts.items
{
    public class BundlerMonthlyProfile : Profile
    {
        public BundlerMonthlyProfile() 
        {
            CreateMap<BundlerMonthlyRequest, BundlerMonthly>()
                .IncludeBase<ItemRequest, Item>()
                .ForMember(m => m.Items, src => src.Ignore());
        }
    }
}
