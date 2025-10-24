using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class Inventario
    {       
        public string nombre { get; set; } 
        public string categoria { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; } 
        

        public Inventario(string nombre, string categoria, int cantidad, double precio)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.cantidad = cantidad;
            this.precio = precio;
            
        }
    }
}
