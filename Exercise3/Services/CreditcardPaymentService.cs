using Exercise2.Services.Logging;

namespace Exercise2.Services;

public class CreditcardPaymentService(ILogger Logger) : IPaymentService
{
    public bool ProcessPayment(decimal money)
    {
        if (money <= 0)
        {
            throw new ArgumentException("Cannot pay less than 0 euro");
        }

        Logger.Log("Sending invoice to credit card");
        // Do payment
        Logger.Log($"Invoice for {money} euros has been created successfully!");

        return true;
    }
}
