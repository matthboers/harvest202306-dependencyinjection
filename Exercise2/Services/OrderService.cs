using Exercise2.Domain;

namespace Exercise2.Services;

public class OrderService(IPaymentService paymentService) : IOrderService
{
    public void PlaceOrder(Item item)
    {
        // Business logic voor het plaatsen van een bestelling
        Console.WriteLine($"Placing order for a(n) {item.Name}");

        // Betaling verwerken
        paymentService.ProcessPayment(item.Price);
    }
}