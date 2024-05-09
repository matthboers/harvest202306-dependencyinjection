using Exercise1.Domain;
using Exercise1.Services;

namespace Exercise1;

internal class Program
{
    static readonly List<Item> Items = [
        new Item("Banana", 1.49M),
        new Item("Apple", 0.99M),
        new Item("Strawberry", 0.60M)
    ];

    static void Main(string[] args)
    {
        OrderService orderService = new();
        orderService.PlaceOrder(Items[1]);
    }
}
