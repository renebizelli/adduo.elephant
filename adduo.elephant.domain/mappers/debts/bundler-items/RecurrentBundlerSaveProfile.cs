using adduo.elephant.domain.entities.debts.bundler_items;

using adduo.elephant.domain.requests.debts.bundler_items;
using AutoMapper;
using System.Collections.Generic;

namespace adduo.elephant.domain.mappers.debts.bundler_items
{
    public class RecurrentBundlerSaveProfile : Profile
    {
        public RecurrentBundlerSaveProfile()
        {
            CreateMap<RecurrentBundlerSaveRequest, RecurrentBundler>()
                .IncludeBase<ItemBundlerRequest, ItemBundler>()
                .ForMember(d => d.Values, src => src.MapFrom((s, d) =>
                {
                    var values = new List<RecurrentBundlerValue>();

                    if (s.Value.GetValue() > 0)
                    {
                        values = new List<RecurrentBundlerValue>()
                                    {
                                        new RecurrentBundlerValue(s.Description.Value, s.Value.GetValue())
                                    };
                    }

                    return values;
                }));
        }
    }
}
