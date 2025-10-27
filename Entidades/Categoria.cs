using System.Xml.Linq;

namespace T2.Entidades
{
    public class G19_Categoria
    {
        public int G19_id { get; set; }
        public string G19_nombre { get; set; }
        
        public G19_Categoria(int id, string nombre)
        {
            this.G19_id = id;
            this.G19_nombre = nombre;
        }
        
        public override string ToString()
        {
            return G19_nombre;
        }
    }
}
