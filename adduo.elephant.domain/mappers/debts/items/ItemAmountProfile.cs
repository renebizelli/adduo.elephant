using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.requests.debts.items;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts.items
{
    public class ItemAmountProfile : Profile
    {
        public ItemAmountProfile()
        {
            CreateMap<ItemAmountRequest, ItemAmount>()
                .IncludeBase<ItemRequest, Item>()
               .ForMember(d => d.Amount, a => a.MapFrom(m => m.Amount.GetValue()));
        }
    }
}

