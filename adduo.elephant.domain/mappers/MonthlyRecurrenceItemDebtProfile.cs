using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using AutoMapper;

namespace adduo.elephant.domain.mappers
{
    public class MonthlyRecurrenceItemDebtProfile : Profile
    {
        public MonthlyRecurrenceItemDebtProfile() 
        {
            CreateMap<MonthlyRecurrenceItemDebtRequest, MonthlyRecurrenceItemDebt>()
                .IncludeBase<ItemDebtRequest, ItemDebt>();
        }
    }
}
