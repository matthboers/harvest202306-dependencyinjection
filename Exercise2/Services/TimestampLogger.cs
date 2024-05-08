namespace Exercise2.Services;

public class TimestampLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(DateTimeOffset.Now.ToString() + message);
    }
}
