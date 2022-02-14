using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using AutoMapper;

namespace adduo.elephant.domain.mappers
{
    public class PontualItemDebtProfile : Profile
    {
        public PontualItemDebtProfile()  
        {
            CreateMap<PontualItemDebtRequest, PontualItemDebt>()
                .IncludeBase<ItemDebtRequest, ItemDebt>()
                .ForMember(d => d.Month, a => a.MapFrom(src => src.Month.GetValue()))
                .ForMember(d => d.Year, a => a.MapFrom(src => src.Year.GetValue()));
        }
    }
}

