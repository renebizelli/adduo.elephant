using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using AutoMapper;
using System;

namespace adduo.elephant.domain.mappers.debts
{
    public class DebtProfile : Profile
    {
        public DebtProfile()
        {
            CreateMap<DebtRequest, Debt>()
               .ForMember(d => d.Id, a => a.MapFrom(src => src.Id))
               .ForMember(d => d.Name, a => a.MapFrom(src => src.Name.Value))
               .ForMember(d => d.Status, a => a.Ignore())
               .ForMember(d => d.CreatedAt, a => a.MapFrom(m => DateTime.Now))
                .ForMember(d => d.Category, a => a.Ignore())
               .ForMember(d => d.CategoryId, a => a.MapFrom(src => src.CategoryId.GetValue()));

            CreateMap<Debt, dtos.debts.Debt>()
             .ForMember(d => d.Id, a => a.MapFrom(src => src.Id))
             .ForMember(d => d.Name, a => a.MapFrom(src => src.Name))
             .ForMember(d => d.Status, a => a.MapFrom(src => (int)src.Status))
             .ForMember(d => d.CreatedAt, a => a.MapFrom(src => src.CreatedAt))
             .ForMember(d => d.Category, a => a.MapFrom(src => new dtos.Category(src.Category.Id, src.Category.Name)));
        }
    }
}
