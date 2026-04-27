using ToDo.Entidades;

namespace ToDo.Datos
{
    public class ItemRepository
    {
        public List <Item> ObtenerTodos()
        {

            var items = new List<Item>
            {
                new Item { Titulo = "Comprar leche", Estado = false },
                new Item { Titulo = "Pasear al perro", Estado = true },
                new Item { Titulo = "Hacer la tarea", Estado = false }
            };
            return items;
        }
    }
}
