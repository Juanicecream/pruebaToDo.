Console.WriteLine("TODO!");





for (int i = 1; i <= 10; i++) { 
var item = new ToDo.Entidades.Item()
{
    Titulo = $"Item {i}",
    Estado = (i % 2 == 0)
};
    Console.WriteLine($"Titulo:{item.Titulo}, Estado:{item.Estado}");
}

