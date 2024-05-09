namespace Exercise2.Services.Logging;

public class TimestampLogger : ILoggerDecorator
{
    public string Decorate(string message)
    {
        return $"{DateTimeOffset.Now} | {message}";
    }
}
