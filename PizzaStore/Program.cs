using PizzaStore;

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

// Agregar los endpoints.

app.MapGet("/pizza/{id}", (int id) => PizzaDb.GetPizza(id));
app.MapGet("/pizzas", () => PizzaDb.GetPizzas());
app.MapPost("/pizzas", (Pizza pizza) => PizzaDb.CreatePizza(pizza));
app.MapPut("/pizzas", (Pizza pizza) => PizzaDb.UpdatePizza(pizza));
app.MapDelete("/pizzas/{id}", (int id) => PizzaDb.RemovePizza(id));


app.Run();
