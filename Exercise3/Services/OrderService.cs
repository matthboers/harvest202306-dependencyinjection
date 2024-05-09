using Exercise2.Domain;
using Exercise2.Services.Logging;

namespace Exercise2.Services;

public class OrderService(IPaymentService paymentService, ILogger logger) : IOrderService
{
    public void PlaceOrder(Item item)
    {
        // Business logic voor het plaatsen van een bestelling
        logger.Log($"Placing order for a(n) {item.Name}");

        // Betaling verwerken
        paymentService.ProcessPayment(item.Price);
    }
}