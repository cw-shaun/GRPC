using FinanceService.Dto;
using FinanceService.Models;
using Grpc.Core;
using Google.Protobuf.Collections;

namespace FinanceService.Services;

public class IsCarValueForMoneyService: FinanceService.FinanceServiceBase{
    private readonly ILogger<GreeterService> _logger;
    public IsCarValueForMoneyService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override async Task<MultiplStatuses> GetCars(IsCarValueForMoney request, ServerCallContext context)
    {
        
        List<StockDto> stocks= new List<StockDto>();

        Result abc = new() {
            Id = 1,
            IsValueForMoney = false
        };

        MultiplStatuses mulStatus = new();
        // mulStatus.Status.AddRange();

        return mulStatus;
    }

}