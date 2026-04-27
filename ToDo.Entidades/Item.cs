namespace ToDo.Entidades
{
    public class Item
    {

        public string Titulo { get; set; }

        private bool _estado;
        public bool Estado
        {
            get { return _estado; }
            set { _estado = value; }
        
        }

        public override string ToString()
        {
            return $"{Titulo} ({(Estado ? "Completo" : "Pendiente")})";
        }
    }

}
