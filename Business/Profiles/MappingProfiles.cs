using AutoMapper;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs.Current;
using Entities.DTOs.Stock;
using Entities.DTOs.StockPrice;
using Entities.DTOs.User;

namespace Business.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ListUser, AppUser>();
            CreateMap<AppUser, ListUser>();

            CreateMap<ListCurrent, Current>();
            CreateMap<Current, ListCurrent>();

            CreateMap<Current, AddCurrent>();
            CreateMap<AddCurrent, Current>();

            CreateMap<Stock, AddStock>();
            CreateMap<AddStock, Stock>();

            CreateMap<StockPrice, AddStockPrice>();
            CreateMap<AddStockPrice, StockPrice>();

            CreateMap<ListStock, Stock>();
            CreateMap<Stock, ListStock>();


        }
    }
}
