
var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, config) =>
    config.ReadFrom.Configuration(context.Configuration));

builder.Services.AddCarterWithAssemblies(typeof(CatalogModule).Assembly);

// add service configuration. This will register services in the DI
builder.Services
    .AddCatalogModule(builder.Configuration)
    .AddBasketModule(builder.Configuration)
    .AddOrderingModule(builder.Configuration);

builder.Services.AddExceptionHandler<CustomExceptionHandler>();

// Configure HTTP request pipeline
var app = builder.Build();

app.MapCarter();

app.UseSerilogRequestLogging();

app.UseExceptionHandler(options => { });
app.UseCatalogModule()
    .UseBasketModule()
    .UseOrderingModule();

app.Run();
