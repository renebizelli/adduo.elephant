using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.requests.debts.items;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts.items
{
    public class YearlyProfile : Profile
    {
        public YearlyProfile()
        {
            CreateMap<YearlyRequest, Yearly>()
                .IncludeBase<ItemAmountRequest, ItemAmount>()
                .ForMember(d => d.DueMonth, a => a.MapFrom(src => src.DueMonth.GetValue()));

            CreateMap<Yearly, dtos.debts.items.Yearly>()
                .IncludeBase<ItemAmount, dtos.debts.items.ItemAmount>()
                .ForMember(d => d.DueMonth, a => a.MapFrom(src => src.DueMonth));

        }
    }
}
