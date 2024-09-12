using AutoMapper;
using FinanceService.Dto;
using FinanceService.Models;

public class AutoMapperProfile:Profile{
    public AutoMapperProfile(){
        CreateMap<Stock,StockDto>().ForMember(
            dest=>dest.IsValueForMoney,opt=>opt.MapFrom(src=>src.Km<10000 && src.CarPrice<200000)
        );
    }
}