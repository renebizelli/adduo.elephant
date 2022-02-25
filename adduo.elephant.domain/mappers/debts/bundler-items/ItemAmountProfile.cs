using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts.bundler_items
{
    public class ItemAmountProfile : Profile
    {
        public ItemAmountProfile()
        {
            CreateMap<ItemAmountRequest, ItemAmount>()
                .IncludeBase<ItemRequest, Item>()
               .ForMember(d => d.Amount, a => a.MapFrom(m => m.Value.GetValue()));
        }
    }
}

