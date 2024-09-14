using FinanceService.Dto;
namespace FinanceService.Services;

public interface IStockService{
    Task<IEnumerable<StockDto>> GetCarsByIds(string ids);
}