using adduo.elephant.domain.entities.debts.bundler_items;

using adduo.elephant.domain.requests.debts.bundler_items;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts.bundler_items
{
    public class RecurrentProfile : Profile
    {
        public RecurrentProfile()
        {
            CreateMap<RecurrentRequest, Recurrent>()
                .IncludeBase<ItemRequest, Item>();
        }
    }
}
