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
               .ForMember(d => d.CategoryId, a => a.MapFrom(src => src.CategoryId.GetValue()));

            CreateMap<ItemDebtRequest, ItemDebt>()
                .IncludeBase<DebtRequest, Debt>()
                .ForMember(d => d.DueDay, a => a.MapFrom(src => src.DueDay.GetValue()))
                .ForMember(d => d.InComeId, a => a.MapFrom(src => src.InComeId.GetValue()));

            CreateMap<PontualItemDebtRequest, PontualItemDebt>()
                .IncludeBase<ItemDebtRequest, ItemDebt>()
                .ForMember(d => d.Month, a => a.MapFrom(src => src.Month.GetValue()))
                .ForMember(d => d.Year, a => a.MapFrom(src => src.Year.GetValue()));

            //CreateMap<PontualItemDebtRequest, PontualItemDebt>()
            //   .ForMember(d => d.Id, a => a.MapFrom(src => src.Id))
            //   .ForMember(d => d.Value, a => a.MapFrom(src => src.Value.Value))
            //   .ForMember(d => d.CategoryId, a => a.MapFrom(src => src.CategoryId.Value))
            //   .ForMember(d => d.DueDay, a => a.MapFrom(src => src.DueDay.Value))
            //   .ForMember(d => d.InComeId, a => a.MapFrom(src => src.InComeId.Value))
            //   .ForMember(d => d.Month, a => a.MapFrom(src => src.Month.Value))
            //   .ForMember(d => d.Year, a => a.MapFrom(src => src.Year.Value));
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