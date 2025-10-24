namespace T2.Entidades
{
    public class G19_Producto
    {       
        public int id { get; set; }
        public string nombre { get; set; }
        public int stock { get; set; }
        public double precio { get; set; }
        public int categoria_id { get; set; }

        public G19_Producto(string nombre, int stock, double precio, int categoria_id)
        {
            this.nombre = nombre;
            this.stock = stock;
            this.precio = precio;
            this.categoria_id = categoria_id;
        }
    }
}
