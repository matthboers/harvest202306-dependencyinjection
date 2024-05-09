using Exercise2.Domain;
using Exercise2.Services;
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
        // TODO: Vervang handmatige DI met een DI Container

        OrderService orderServiceWithIdeal = new(new IdealPaymentService());
        orderServiceWithIdeal.PlaceOrder(Items[1]);
    }
}
