using FinanceService.Dto;
using FinanceService.Models;
using FinanceService.Repositories;
using Grpc.Core;
using FinanceService.Services;
namespace FinanceService.Services;

public class IsCarValueForMoneyService : FinanceService.FinanceServiceBase
{
    private readonly ILogger<GreeterService> _logger;
    private readonly IStockService _service;
    public IsCarValueForMoneyService(IStockService service, ILogger<GreeterService> logger)
    {
        _service = service;
        _logger = logger;
    }

    public override async Task<MultiplStatuses> GetCars(IsCarValueForMoney request, ServerCallContext context)
    {
        // int[] ids = request.Idstring.Split(',').Select(Int32.Parse).ToList();
        // foreach (var id in ids)
        // {
        //     Console.WriteLine(carid);
        // }


        IEnumerable<StockDto> cars = await _service.GetCarsByIds(request.Ids);

        Result abc = new();

        MultiplStatuses mulStatus = new();
        // IEnumerable<Result> results = cars.Cast<Result>();
        foreach (StockDto car in cars)
        {
            Console.WriteLine(car.IsValueForMoney);
            mulStatus.Status.Add(new Result
            {
                Id = car.Id,
                IsValueForMoney = car.IsValueForMoney
            });
        }


        return mulStatus;
    }

}