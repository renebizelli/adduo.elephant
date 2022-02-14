using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.mappers.resolvers;
using adduo.elephant.domain.requests;
using AutoMapper;
using System;

namespace adduo.elephant.domain.mappers
{
    public class DebtProfile : Profile
    {
        public DebtProfile()
        {
            CreateMap<DebtRequest, Debt>()
               .ForMember(d => d.Id, a => a.Ignore())
               .ForMember(d => d.Amount, a => a.MapFrom(m => m.Value.GetValue()))
               .ForMember(d => d.Name, a => a.MapFrom(src => src.Name.Value))
               .ForMember(d => d.Status, a => a.Ignore())
               .ForMember(d => d.CreatedAt, a => a.MapFrom(m => DateTime.Now))
               .ForMember(d => d.Tags, a => a.MapFrom<TagResolver>());
        }
    }
}

