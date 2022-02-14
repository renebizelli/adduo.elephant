using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using AutoMapper;

namespace adduo.elephant.domain.mappers
{
    public class YearlyRecurrenceItemDebtProfile : Profile
    {
        public YearlyRecurrenceItemDebtProfile() 
        {
            CreateMap<YearlyRecurrenceItemDebtRequest, YearlyRecurrenceItemDebt>()
                .IncludeBase<ItemDebtRequest, ItemDebt>()
                .ForMember(d => d.DueMonth, a => a.MapFrom(src => src.DueMonth.GetValue()));
        }
    }
}
