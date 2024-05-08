﻿using Exercise1.Domain;

namespace Exercise1.Services;

public class OrderService
{
    private readonly IPaymentService paymentService = new IdealPaymentService();

    public void PlaceOrder(Item item)
    {
        // Business logic voor het plaatsen van een bestelling
        Console.WriteLine($"Placing order for a(n) {item.Name}");

        // Betaling verwerken
        paymentService.ProcessPayment(item.Price);
    }
}