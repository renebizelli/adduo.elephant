using adduo.elephant.domain.entities.debts;
using adduo.elephant.domain.requests;
using AutoMapper;

namespace adduo.elephant.domain.mappers
{
    public class PontualItemDebtProfile : Profile
    {
        public PontualItemDebtProfile()
        {
            CreateMap<DebtRequest, Debt>()
               .ForMember(d => d.Id, a => a.Ignore())
               .ForMember(d => d.Value, a => a.MapFrom(src => src.Value.Value))
               .ForMember(d => d.Name, a => a.MapFrom(src => src.Name.Value))
               .ForMember(d => d.Tags, a => a.MapFrom(src => src.Tags.Value));

            CreateMap<ItemDebtRequest, ItemDebt>()
                .IncludeBase<DebtRequest, Debt>()
                .ForMember(d => d.DueDay, a => a.MapFrom(src => src.DueDay.GetValue()))
                .ForMember(d => d.InComeId, a => a.MapFrom(src => src.InComeId.GetValue()));

            CreateMap<PontualItemDebtRequest, PontualItemDebt>()
                .IncludeBase<ItemDebtRequest, ItemDebt>()
                .ForMember(d => d.Month, a => a.MapFrom(src => src.Month.GetValue()))
                .ForMember(d => d.Year, a => a.MapFrom(src => src.Year.GetValue()));
        }
    }
}


//private T EntryFactory<T>(EntryMessage entry) where T : entries.Entry<string>
//{
//    var prop = Activator.CreateInstance<T>();

//    if (entry is EntryMessage e)
//    {
//        prop.Name = e.Name;
//        prop.Value = e.Value;
//        prop.SetErrorCode((entries.ErrorCode)e.ErrorCode, (entries.StatusCode)e.StatusCode);
//    }

//    return prop;
//}

//private Protos.EntryMessage EntryFactory(entries.Entry<string> entry)
//{
//    var prop = new Protos.EntryMessage();

//    if (entry is entries.Entry<string> e)
//    {
//        prop.Name = e.Name.EmptyIfNull();
//        prop.Value = e.Value.EmptyIfNull();
//        prop.StatusCode = (int)e.Status;
//        prop.ErrorCode = (int)e.Error;
//    }

//    return prop;
//}