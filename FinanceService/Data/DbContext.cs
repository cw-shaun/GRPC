using System.Data;
using FinanceService.Models;
using MySql.Data.MySqlClient;


namespace FinanceService.Data;

public class StockDbContext{
    public readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public StockDbContext(IConfiguration configuration){
        _connectionString=configuration.GetConnectionString("DefaultConnection");
    }

    public IDbConnection CreateConnection(){
        return new MySqlConnection(_connectionString);
    }


}