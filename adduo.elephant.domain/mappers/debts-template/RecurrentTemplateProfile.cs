using adduo.elephant.domain.entities.debts_template;
using adduo.elephant.domain.requests.debts_template;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts_template
{
    public class RecurrentTemplateProfile : Profile
    {
        public RecurrentTemplateProfile()
        {
            CreateMap<RecurrentTemplateRequest, RecurrentTemplate>()
                 .IncludeBase<DebtTemplateRequest, DebtTemplate>();
        }
    }
}
