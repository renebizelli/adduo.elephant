using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using AutoMapper;

namespace adduo.elephant.domain.mappers
{
    public class InstallmentsItemDebtProfile : Profile
    {
        public InstallmentsItemDebtProfile()  
        {
            CreateMap<InstallmentsItemDebtRequest, InstallmentsItemDebt>()
                .IncludeBase<ItemDebtRequest, ItemDebt>()
                .ForMember(d => d.StartMonth, a => a.MapFrom(src => src.StartMonth.GetValue()))
                .ForMember(d => d.StartYear, a => a.MapFrom(src => src.StartYear.GetValue()))
                .ForMember(d => d.Installments, a => a.MapFrom(src => src.Installments.GetValue()));
        }
    }
}

