using FinanceService.Models;

namespace FinanceService.Repositories;

public interface IStockRepository{
    Task<IEnumerable<Stock>> GetStockAsync(string id);
}