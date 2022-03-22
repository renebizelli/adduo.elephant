using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace adduo.elephant.domain.mappers
{
    public class SpreadSheetProfile : Profile
    {
        public SpreadSheetProfile()
        {
            CreateMap<entities.SpreadSheet, dtos.SpreadSheet>()
                .ForMember(d => d.Id, src => src.MapFrom(m => m.Id))
                .ForMember(d => d.Year, src => src.MapFrom(m => m.Year))
                .ForMember(d => d.Month, src => src.MapFrom(m => m.Month))
                .ForMember(d => d.CreatedAt, src => src.MapFrom(m => m.CreatedAt))
                .AfterMap((source, dest, context) => {

                });
        }
    }
}
