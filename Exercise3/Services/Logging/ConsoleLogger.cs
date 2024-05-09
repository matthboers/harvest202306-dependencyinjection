namespace Exercise3.Services.Logging;

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        var newMessage = message;

        Console.WriteLine(newMessage);
    }
}
