namespace Exercise1.Services;

public class CreditcardPaymentService : IPaymentService
{
    public bool ProcessPayment(decimal money)
    {
        if (money <= 0)
        {
            throw new ArgumentException("Cannot pay less than 0 euro");
        }

        Console.WriteLine("Sending invoice to credit card");
        // Do payment
        Console.WriteLine($"Invoice for {money} euros has been created successfully!");

        return true;
    }
}
