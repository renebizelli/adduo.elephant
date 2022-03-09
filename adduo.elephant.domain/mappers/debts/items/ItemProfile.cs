using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.requests;
using adduo.elephant.domain.requests.debts.items;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts.items
{
    public class ItemProfile : Profile
    {
        public ItemProfile()  
        {
            CreateMap<ItemRequest, Item>()
                .IncludeBase<DebtRequest, Debt>()
                .ForMember(d => d.DueDay, a => a.MapFrom(src => src.DueDayOfMonth.GetValue()))
                .ForMember(d => d.InComeId, a => a.MapFrom(src => src.InComeId.GetValue()))
                .ForMember(d => d.InCome, a => a.Ignore())
                .ForMember(d => d.SpreadSheetItems, a => a.Ignore());

            CreateMap<Item, dtos.debts.items.Item>()
                .IncludeBase<Debt, dtos.debts.Debt>()
                .ForMember(d => d.DueDay, a => a.MapFrom(src => src.DueDay))
                .ForMember(d => d.InCome, a => a.MapFrom(src => new dtos.InCome(src.InComeId, src.InCome.Name)));
        }
    }
}

