using adduo.elephant.domain.entities.debts_template;
using adduo.elephant.domain.requests.debts_template;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts_template
{
    public class MonthlyTemplateProfile : Profile
    {
        public MonthlyTemplateProfile()
        {
            CreateMap<MonthlyTemplateRequest, MonthlyTemplate>()
                 .IncludeBase<DebtAmountTemplateRequest, DebtAmountTemplate>();
        }
    }
}
