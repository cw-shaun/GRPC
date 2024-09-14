using AutoMapper;
using FinanceService.Dto;
using FinanceService.Repositories;

namespace FinanceService.Services;

public class StockService:IStockService{
    private readonly IStockRepository _stockrepo;
    private readonly IMapper _mapper;

    public StockService(IStockRepository stockrepo,IMapper mapper){
        _stockrepo=stockrepo;
        _mapper=mapper;
    }

    public async Task<IEnumerable<StockDto>> GetCarsByIds(string ids){
        var stocks=await _stockrepo.GetStockAsync(ids);
        return _mapper.Map<IEnumerable<StockDto>>(stocks);
    }

}