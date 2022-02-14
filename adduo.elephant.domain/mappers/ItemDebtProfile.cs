using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using AutoMapper;

namespace adduo.elephant.domain.mappers
{
    public class ItemDebtProfile : Profile
    {
        public ItemDebtProfile()  
        {
            CreateMap<ItemDebtRequest, ItemDebt>()
                .IncludeBase<DebtRequest, Debt>()
                .ForMember(d => d.DueDay, a => a.MapFrom(src => src.DueDay.GetValue()))
                .ForMember(d => d.InComeId, a => a.MapFrom(src => src.InComeId.GetValue()))
                .ForMember(d => d.InCome, a => a.Ignore())
                .ForMember(d => d.SpreadSheetItems, a => a.Ignore());
        }
    }
}

