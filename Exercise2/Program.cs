using Exercise2.Domain;
using Exercise2.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Security;

namespace Exercise2;

internal class Program
{
    static readonly List<Item> Items = [
        new Item("Banana", 1.49M),
        new Item("Apple", 0.99M),
        new Item("Strawberry", 0.60M)
    ];

    static void Main(string[] args)
    {
        var services = new ServiceCollection();

        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<IPaymentService, IdealPaymentService>();
        services.AddTransient<ILogger, TimestampLogger>();

        var container = services.BuildServiceProvider();

        var orderService = container.GetRequiredService<IOrderService>();

        orderService.PlaceOrder(Items[1]);
    }
}
