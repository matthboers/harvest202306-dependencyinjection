namespace Exercise2.Services.Logging;

public class CounterLogger : ILoggerDecorator
{
    readonly Dictionary<string, int> logMessageCounter = new();

    public string Decorate(string message)
    {
        logMessageCounter[message] = logMessageCounter.GetValueOrDefault(message) + 1;
        return $"Seen this message {logMessageCounter[message]} times | {message}";
    }
}
