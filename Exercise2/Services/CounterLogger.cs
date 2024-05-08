namespace Exercise2.Services;

public class CounterLogger : ILogger
{
    private int numberOfCalls = 0;

    public void Log(string message)
    {
        Console.WriteLine($"{message}, this is log statement number {numberOfCalls}");
    }
}
