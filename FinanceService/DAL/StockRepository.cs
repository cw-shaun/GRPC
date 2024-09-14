
using System.Data;
using System.Data.Common;
using FinanceService.Data;
using FinanceService.Models;
using Dapper;
using Grpc.Core;

namespace FinanceService.Repositories;

public class StockRepository: IStockRepository{
    private readonly StockDbContext _context;

    public StockRepository(StockDbContext context){
        _context=context;
    }

    public async Task<IEnumerable<Stock>> GetStockAsync(string id){
        var idList = id.Split(',').Select(int.Parse).ToList();
        IDbConnection connection=_context.CreateConnection();
        string query="SELECT * from stocks where id in @id";
        var stocks = await connection.QueryAsync<Stock>(query.ToString(), new { id = idList });
        return stocks;
    }

}