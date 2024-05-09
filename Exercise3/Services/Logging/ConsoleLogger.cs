namespace Exercise2.Services.Logging;

public class ConsoleLogger(IEnumerable<ILoggerWrapper> Wrappers) : ILogger
{
    public void Log(string message)
    {
        var newMessage = message;

        foreach (var wrapper in Wrappers) 
        { 
            newMessage = wrapper.Decorate(newMessage);    
        }

        Console.WriteLine(newMessage);
    }
}
