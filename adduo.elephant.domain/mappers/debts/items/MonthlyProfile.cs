using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.requests.debts.items;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts.items
{
    public class MonthlyProfile : Profile
    {
        public MonthlyProfile() 
        {
            CreateMap<MonthlyRequest, Monthly>()
                .IncludeBase<ItemAmountRequest, ItemAmount>();
        }
    }
}
