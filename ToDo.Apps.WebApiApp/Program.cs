using ToDo.Entidades;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/api/item", () =>
{
    //var items = new List<ToDo.Entidades.Item>();
    //for (int i = 1; i <= 10; i++)
    //{
    //    var item = new ToDo.Entidades.Item()
    //    {
    //        Titulo = $"Item {i}",
    //        Estado = (i % 2 == 0)
    //    };
    //    Console.WriteLine($"Titulo:{item.Titulo}, Estado:{item.Estado}");
    //    items.Add(item);
    //}
    var itemNegocio = new ToDo.Negocio.ItemNegocio();
    var items = itemNegocio.ObtenerTodos();

    foreach (var item in items)
    {
        Console.WriteLine($"Titulo: {item.Titulo}, Estado: {(item.Estado ? "Completo" : "Pendiente")}");
    }


    return items;
});



app.Run();

