using Exercise3.Domain;
using Exercise3.Services;
using Exercise3.Services.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace Exercise3;

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

        services.AddTransient<ILogger, ConsoleLogger>();
        services.AddSingleton<ILoggerDecorator, CounterLogger>();
        services.AddTransient<ILoggerDecorator, TimestampLogger>();

        var container = services.BuildServiceProvider();

        var orderService = container.GetRequiredService<IOrderService>();

        orderService.PlaceOrder(Items[1]);
        orderService.PlaceOrder(Items[2]);
        orderService.PlaceOrder(Items[0]);
        orderService.PlaceOrder(Items[1]);
    }
}
