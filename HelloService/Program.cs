using HelloService;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Host.UseWindowsService();

var host = builder.Build();
host.Run();
