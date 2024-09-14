using System.Threading.Tasks;
using Grpc.Net.Client;
using FinanceService;



var channel = GrpcChannel.ForAddress("http://localhost:5213");
var client = new FinanceService.FinanceService.FinanceServiceClient(channel);
IsCarValueForMoney cars= new IsCarValueForMoney(){
    Ids="1,4,5,6"
};
var result = client.GetCars(cars);
Console.WriteLine(result);

