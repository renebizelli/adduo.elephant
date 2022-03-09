using adduo.elephant.domain.entities.debts.bundler_items;
using adduo.elephant.domain.requests.debts.bundler_items;
using AutoMapper;

namespace adduo.elephant.domain.mappers.debts.bundler_items
{
    public class RecurrentBundlerUpdateProfile : Profile
    {
        public RecurrentBundlerUpdateProfile()
        {
            CreateMap<RecurrentBundlerUpdateRequest, RecurrentBundler>()
                .IncludeBase<ItemBundlerRequest, ItemBundler>()
                .ForMember(d => d.Values, s => s.Ignore());
        }
    }
}
