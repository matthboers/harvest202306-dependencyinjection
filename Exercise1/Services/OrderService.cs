using Exercise1.Domain;

namespace Exercise1.Services;

public class OrderService
{
    public IPaymentService PaymentService { get; set; }

    public OrderService(IPaymentService paymentService)
    {
        PaymentService = paymentService;
    }

    public void PlaceOrder(Item item)
    {
        // Business logic voor het plaatsen van een bestelling
        Console.WriteLine($"Placing order for a(n) {item.Name}");

        // Betaling verwerken
        PaymentService.ProcessPayment(item.Price);
    }

    public void SetPaymentService(IPaymentService paymentService)
    {
        PaymentService = paymentService;
    }
}