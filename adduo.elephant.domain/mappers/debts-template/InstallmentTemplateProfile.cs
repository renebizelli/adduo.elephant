using adduo.elephant.domain.entities.debts_template;
using adduo.elephant.domain.requests.debts_template;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts_template
{
    public class InstallmentTemplateProfile : Profile
    {
        public InstallmentTemplateProfile()
        {
            CreateMap<InstallmentTemplateRequest, InstallmentTemplate>()
                 .IncludeBase<DebtAmountTemplateRequest, DebtAmountTemplate>()
                .ForMember(d => d.StartMonth, a => a.MapFrom(src => src.StartMonth.GetValue()))
                .ForMember(d => d.StartYear, a => a.MapFrom(src => src.StartYear.GetValue()))
                .ForMember(d => d.Installments, a => a.MapFrom(src => src.Installments.GetValue()))
                .ForMember(d => d.StartPeriod, a => a.MapFrom(src => src.Installments.GetValue()))
                .AfterMap((src, dest) =>
                {
                    dest.SetPeriod();
                });
        }
    }
}
