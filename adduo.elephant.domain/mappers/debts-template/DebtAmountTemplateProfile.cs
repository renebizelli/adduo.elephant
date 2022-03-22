using adduo.elephant.domain.entities.debts_template;
using adduo.elephant.domain.requests.debts_template;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts_template
{
    public class DebtAmountTemplateProfile : Profile
    {
        public DebtAmountTemplateProfile()
        {
            CreateMap<DebtAmountTemplateRequest, DebtAmountTemplate>()
                .IncludeBase<DebtTemplateRequest, DebtTemplate>()
                .ForMember(d => d.Amount, a => a.MapFrom(src => src.Amount.GetValue()));
        }
    }
}
