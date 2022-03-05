using adduo.elephant.domain.entities.debts.bundler_items;

using adduo.elephant.domain.requests.debts.bundler_items;
using AutoMapper;
using System.Collections.Generic;

namespace adduo.elephant.domain.mappers.debts.bundler_items
{
    public class RecurrentSaveProfile : Profile
    {
        public RecurrentSaveProfile()
        {
            CreateMap<RecurrentSaveRequest, Recurrent>()
                .IncludeBase<ItemRequest, Item>()
                .ForMember(d => d.Values, src => src.MapFrom((s, d) =>
                {
                    var values = new List<RecurrentValue>();

                    if (s.Value.GetValue() > 0)
                    {
                        values = new List<RecurrentValue>()
                                    {
                                        new RecurrentValue(s.Description.Value, s.Value.GetValue())
                                    };
                    }

                    return values;
                }));
        }
    }
}
