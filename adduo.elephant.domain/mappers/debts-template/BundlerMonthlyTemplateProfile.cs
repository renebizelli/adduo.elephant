using adduo.elephant.domain.entities.debts_template;
using adduo.elephant.domain.requests.debts_template;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts_template
{
    public class BundlerMonthlyTemplateProfile : Profile
    {
        public BundlerMonthlyTemplateProfile()
        {
            CreateMap<BundlerMonthlyTemplateRequest, BundlerMonthlyTemplate>()
                 .IncludeBase<DebtTemplateRequest, DebtTemplate>()
                 .ForMember(d => d.Debts, src => src.Ignore());
        }
    }
}
