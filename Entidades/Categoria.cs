using System.Xml.Linq;

namespace T2.Entidades
{
    public class G19_Categoria
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public G19_Categoria(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public override string ToString()
        {
            return nombre;
        }
    }
}
