namespace T2.Entidades
{
    public class G19_Producto
    {       
        public int G19_id { get; set; }
        public string G19_nombre { get; set; }
        public int G19_stock { get; set; }
        public double G19_precio { get; set; }
        public int G19_categoria_id { get; set; }

        public G19_Producto(string nombre, int stock, double precio, int categoria_id)
        {
            this.G19_nombre = nombre;
            this.G19_stock = stock;
            this.G19_precio = precio;
            this.G19_categoria_id = categoria_id;
        }
    }
}
