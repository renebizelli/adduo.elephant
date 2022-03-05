using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using AutoMapper;
using System;

namespace adduo.elephant.domain.mappers.debts.bundler_items
{
    public class RecurrentValueProfile : Profile
    {
        public RecurrentValueProfile()
        {
            CreateMap<RecurrentValueRequest, RecurrentValue>()
                .ForMember(d => d.Id, a => a.Ignore())
                .ForMember(d => d.Recurrent, a => a.Ignore())
                .ForMember(d => d.RecurrentId, a => a.Ignore())
                .ForMember(d => d.CreatedAt, a => a.MapFrom(m => DateTime.Now))
                .ForMember(d => d.Description, a => a.MapFrom(src => src.Description.Value))
                .ForMember(d => d.Amount, a => a.MapFrom(src => src.Amount.GetValue()));
        }
    }
}
