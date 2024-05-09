namespace Exercise2.Services.Logging;

public class TimestampLogger : ILoggerWrapper
{
    public string Decorate(string message)
    {
        return $"{DateTimeOffset.Now} | {message}";
    }
}
