namespace T2
{
    internal class G19_Categoria
    {
        public int id { get; set; }
        public string name { get; set; }
        public G19_Categoria(string name)
        {
            id = G19_Data.ListaCategorias.Count + 1;
            this.name = name;
        }
    }
}
