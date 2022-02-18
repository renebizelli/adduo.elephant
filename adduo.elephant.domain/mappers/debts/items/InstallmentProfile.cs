using adduo.elephant.domain.entities.debts.items;
using adduo.elephant.domain.requests.debts.items;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts.items
{
    public class InstallmentProfile : Profile
    {
        public InstallmentProfile()  
        {
            CreateMap<InstallmentRequest, Installment>()
                .IncludeBase<ItemAmountRequest, ItemAmount>()
                .ForMember(d => d.StartMonth, a => a.MapFrom(src => src.StartMonth.GetValue()))
                .ForMember(d => d.StartYear, a => a.MapFrom(src => src.StartYear.GetValue()))
                .ForMember(d => d.Installments, a => a.MapFrom(src => src.Installments.GetValue()));
        }
    }
}

