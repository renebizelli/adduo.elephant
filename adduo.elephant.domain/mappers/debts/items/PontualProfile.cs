using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.enums;
using adduo.elephant.domain.requests.debts.items;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts.items
{
    public class PontualProfile : Profile
    {
        public PontualProfile()  
        {
            CreateMap<PontualRequest, Pontual>()
                .IncludeBase<ItemAmountRequest, ItemAmount>()
                .ForMember(d => d.Month, a => a.MapFrom(src => src.Month.GetValue()))
                .ForMember(d => d.Year, a => a.MapFrom(src => src.Year.GetValue()));

            CreateMap<Pontual, dtos.debts.items.Pontual>()
                .IncludeBase<ItemAmount, dtos.debts.items.ItemAmount>()
                .ForMember(d => d.Type, a => a.MapFrom(src => DebtType.pontual))
                .ForMember(d => d.Month, a => a.MapFrom(src => src.Month))
                .ForMember(d => d.Year, a => a.MapFrom(src => src.Year));
        }
    }
}

