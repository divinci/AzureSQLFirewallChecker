namespace HelloService;

public class Worker : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Console.WriteLine("Hello World");
        return Task.CompletedTask;
    }
}
