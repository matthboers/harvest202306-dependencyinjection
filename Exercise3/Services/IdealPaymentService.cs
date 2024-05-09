using Exercise2.Services.Logging;

namespace Exercise2.Services;

public class IdealPaymentService(ILogger Logger) : IPaymentService
{
    public bool ProcessPayment(decimal money)
    {
        if (money <= 0)
        {
            throw new ArgumentException("Cannot pay less than 0 euro");
        }

        Logger.Log("Processing payment");
        // Do payment
        Logger.Log($"Payment of {money} euros has completed successfully!");

        return true;
    }
}
