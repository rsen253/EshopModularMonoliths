var builder = WebApplication.CreateBuilder(args);

// add service configuration. This will register services in the DI
builder.Services
    .AddCatalogModule(builder.Configuration)
    .AddBasketModule(builder.Configuration)
    .AddOrderingModule(builder.Configuration);



// Configure HTTP request pipeline
var app = builder.Build();

app.UseCatalogModule()
    .UseBasketModule()
    .UseOrderingModule();

app.Run();
