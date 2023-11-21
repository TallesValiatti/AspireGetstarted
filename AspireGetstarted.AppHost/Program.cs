var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.AspireGetstarted_ApiService>("apiservice");

builder.AddProject<Projects.AspireGetstarted_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();
