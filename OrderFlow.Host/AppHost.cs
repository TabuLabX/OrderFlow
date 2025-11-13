using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);


var postgres = builder.AddPostgres("postgres")
    .WithLifetime(ContainerLifetime.Persistent);

var identityDb = postgres.AddDatabase("identitydb");

var identityService = builder.AddProject<Projects.OrderFlow_Identity>("orderflow-identity")
    .WaitFor(postgres)
    .WithReference(identityDb);


//var databaseName = "app_db";
//var creationScript = $$"""
//    -- Create the database
//    CREATE DATABASE {{databaseName}};

//    """;



builder.Build().Run();
