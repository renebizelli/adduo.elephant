using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.requests.debts.items;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts.items
{
    public class MonthlyBundlerProfile : Profile
    {
        public MonthlyBundlerProfile() 
        {
            CreateMap<MonthlyBundlerRequest, MonthlyBundler>()
                .IncludeBase<ItemRequest, Item>()
                .ForMember(m => m.Items, src => src.Ignore());
        }
    }
}
