namespace Exercise3.Services.Logging;

public class TimestampLoggerDecorator : ILoggerDecorator
{
    public string Decorate(string message)
    {
        return $"{DateTimeOffset.Now} | {message}";
    }
}
