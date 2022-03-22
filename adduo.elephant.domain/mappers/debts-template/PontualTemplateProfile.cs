using adduo.elephant.domain.entities.debts_template;
using adduo.elephant.domain.requests.debts_template;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts_template
{
    public class PontualTemplateProfile : Profile
    {
        public PontualTemplateProfile()
        {
            CreateMap<PontualTemplateRequest, PontualTemplate>()
                 .IncludeBase<DebtAmountTemplateRequest, DebtAmountTemplate>()
                .ForMember(d => d.DueMonth, a => a.MapFrom(src => src.DueMonth.GetValue()))
                .ForMember(d => d.DueYear, a => a.MapFrom(src => src.DueYear.GetValue()));
        }
    }
}
