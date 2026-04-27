namespace ToDo.Entidades.Tests
{
    public class ItemTest
    {
        [Fact]
        public void Test1()
        {
            var item = new Item();
            item.Titulo = "Comprar leche";
            item.Estado = false;

            Assert.Equal("Comprar leche", item.Titulo);
            Assert.False(item.Estado);

        }

        [Fact]
        public void ItemDebeTenerToStringCompleto()
        {
            var item = new Item();
            item.Titulo = "Comprar leche";
            item.Estado = false;

            Assert.Equal("Comprar leche", item.Titulo);
            Assert.False(item.Estado);
            Assert.Equal("Comprar leche (Pendiente)", item.ToString()); 

        }
        [Fact]
        public void ItemDebeTenerToStringCompleto2()
        {
            var item = new Item();
            item.Titulo = "Comprar papa";
            item.Estado = true;

            Assert.Equal("Comprar papa", item.Titulo);
            Assert.True(item.Estado);
            Assert.Equal("Comprar papa (Completo)", item.ToString());

        }
    }
}
