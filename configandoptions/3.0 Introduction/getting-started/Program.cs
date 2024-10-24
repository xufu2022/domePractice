using GettingStarted;

var builder =  
    Host.CreateApplicationBuilder(args);

builder.Configuration

builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
