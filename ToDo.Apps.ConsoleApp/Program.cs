Console.WriteLine("TODO!");


var itemNegocio = new ToDo.Negocio.ItemNegocio();
var items = itemNegocio.ObtenerTodos();

foreach (var item in items)
{
    Console.WriteLine($"Titulo: {item.Titulo}, Estado: {(item.Estado ? "Completo" : "Pendiente")}");
}


/*for (int i = 1; i <= 10; i++) { 
var item = new ToDo.Entidades.Item()
{
    Titulo = $"Item {i}",
    Estado = (i % 2 == 0)
};
    Console.WriteLine($"Titulo:{item.Titulo}, Estado:{item.Estado}");
}
*/
