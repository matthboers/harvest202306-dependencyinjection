namespace Exercise2.Services;

public class IdealPaymentService : IPaymentService
{
    public bool ProcessPayment(decimal money)
    {
        if (money <= 0)
        {
            throw new ArgumentException("Cannot pay less than 0 euro");
        }

        Console.WriteLine("Processing payment");
        // Do payment
        Console.WriteLine($"Payment of {money} euros has completed successfully!");

        return true;
    }
}
