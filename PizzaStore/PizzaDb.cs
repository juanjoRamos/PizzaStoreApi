namespace PizzaStore;

public class PizzaDb
{
    private static List<Pizza> _ListPizzas = new()
    {
        new() {Id=1, Nombre=""},
        new() {Id=2, Nombre=""},
        new() {Id=3, Nombre=""},
    };

    public static List<Pizza> GetPizzas()
    {
        return _ListPizzas;
    }

    public static Pizza? GetPizza(int Id)
    {
        return _ListPizzas.SingleOrDefault(pizza => pizza.Id == Id);
    }

    public static Pizza CreatePizza(Pizza pizza)
    {
        _ListPizzas.Add(pizza);
        return pizza;
    }

    public static Pizza UpdatePizza(Pizza update)
    {
        _ListPizzas = _ListPizzas.Select(pizza =>
        {
            if (pizza.Id == update.Id)
            {
                pizza.Nombre = update.Nombre;
            }
            return pizza;
        }).ToList();
        return update;
    }

    public static void RemovePizza(int Id)
    {
        _ListPizzas = _ListPizzas.FindAll(pizza => pizza.Id != Id).ToList();
    }
}
