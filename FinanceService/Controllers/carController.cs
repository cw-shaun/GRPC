// using FinanceService.Dto;
// using FinanceService.Services;

// namespace FinanceService.Controllers;

// public class CarControllers{
//     private readonly IStockService _service;
//     public CarControllers(IStockService service){
//         _service=service;
//     }
//     public IEnumerable<StockDto> GetCars(string ids){
//         IEnumerable<StockDto> final_cars=_service.GetCarsByIds(ids);
//         return final_cars;
//     }
// }