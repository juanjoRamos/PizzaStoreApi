var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
    {
        Title = "Api PizzaStore",
        Description = "Haciendo las pizzas que amas.",
        Version = "v1"

    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c => 
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "PizzaStore Api v1");

});

app.MapGet("/", () => "Hello World!");

app.Run();
