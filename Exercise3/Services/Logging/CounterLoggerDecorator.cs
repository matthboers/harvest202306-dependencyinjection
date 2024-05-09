namespace Exercise3.Services.Logging;

public class CounterLoggerDecorator : ILoggerDecorator
{
    readonly Dictionary<string, int> logMessageCounter = new();

    public string Decorate(string message)
    {
        logMessageCounter[message] = logMessageCounter.GetValueOrDefault(message) + 1;
        return $"Seen this message {logMessageCounter[message]} times | {message}";
    }
}
