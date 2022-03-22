using adduo.elephant.domain.entities.debts_template;
using adduo.elephant.domain.requests.debts_template;
using AutoMapper;
using System;

namespace adduo.elephant.domain.mappers.debts_template
{
    public class DebtTemplateProfile : Profile
    {
        public DebtTemplateProfile()
        {
            CreateMap<DebtTemplateRequest, DebtTemplate>()
                .ForMember(d => d.Id, a => a.MapFrom(src => src.Id))
                .ForMember(d => d.Name, a => a.MapFrom(src => src.Name.Value))
                .ForMember(d => d.CreatedAt, a => a.MapFrom(m => DateTime.Now))
                .ForMember(d => d.DueDay, a => a.MapFrom(src => src.DueDay.GetValue()))
                .ForMember(d => d.Status, a => a.Ignore())
                .ForMember(d => d.Category, a => a.Ignore())
                .ForMember(d => d.CategoryId, a => a.MapFrom(src => src.CategoryId.GetValue()))
                .ForMember(d => d.Type, a => a.Ignore())
                .AfterMap((src, dest) =>
                {
                   dest.BundlerTemplateId = src.BundlerTemplateId.Equals(Guid.Empty) ? null : src.BundlerTemplateId;
                });

            CreateMap<DebtTemplate, dtos.debts.Debt>()
             .ForMember(d => d.Id, a => a.MapFrom(src => src.Id))
             .ForMember(d => d.Name, a => a.MapFrom(src => src.Name))
             .ForMember(d => d.CreatedAt, a => a.MapFrom(src => src.CreatedAt))
             .ForMember(d => d.Category, a => a.MapFrom(src => new dtos.Category(src.Category.Id, src.Category.Name)));
        }
    }
}
