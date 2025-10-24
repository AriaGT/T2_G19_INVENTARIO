namespace T2
{
    internal class G19_Producto
    {       
        public int id { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public int categoria_id { get; set; }

        public G19_Producto(string nombre, int cantidad, double precio, int categoria_id)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
            this.categoria_id = categoria_id;
        }
    }
}
