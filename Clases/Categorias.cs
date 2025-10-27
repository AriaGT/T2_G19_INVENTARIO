using System;
using System.Linq;
using T2.Entidades;

namespace T2.Clases
{
    public class G19_Categorias
    {
        public G19_Categoria[] G19_ListaCategorias { get; private set; }
        private int G19_contadorCategorias = 0;

        public G19_Categorias()
        {
            G19_ListaCategorias = new G19_Categoria[100];
        }

        public int G19_ObtenerCantidadCategorias()
        {
            return G19_contadorCategorias;
        }

        public void G19_CrearCategoria(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.", nameof(name));

            if (G19_contadorCategorias >= 100)
                throw new InvalidOperationException("No se pueden agregar más categorías. Límite alcanzado (100).");

            int G19_nextId = G19_contadorCategorias + 1;
            var G19_categoria = new G19_Categoria(G19_nextId, name);
            G19_ListaCategorias[G19_contadorCategorias] = G19_categoria;
            G19_contadorCategorias++;
        }

        public void G19_EditarCategoria(int id, string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.", nameof(newName));

            var G19_categoria = G19_BuscarCategoriaPorId(id);
            if (G19_categoria == null)
                throw new ArgumentException("No se puede editar categoría no existente.", nameof(id));

            G19_categoria.nombre = newName;
        }

        public void G19_EliminarCategoria(int id)
        {
            int index = -1;
            for (int i = 0; i < G19_contadorCategorias; i++)
            {
                if (G19_ListaCategorias[i].id == id)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
                throw new ArgumentException("No se puede eliminar categoría no existente.", nameof(id));

            // Mover elementos hacia la izquierda
            for (int i = index; i < G19_contadorCategorias - 1; i++)
            {
                G19_ListaCategorias[i] = G19_ListaCategorias[i + 1];
            }

            G19_ListaCategorias[G19_contadorCategorias - 1] = null;
            G19_contadorCategorias--;
        }

        public G19_Categoria G19_BuscarCategoriaPorId(int id)
        {
            for (int i = 0; i < G19_contadorCategorias; i++)
            {
                if (G19_ListaCategorias[i].id == id)
                    return G19_ListaCategorias[i];
            }
            return null;
        }

        public G19_Categoria G19_BuscarCategoriaPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre de búsqueda no puede estar vacío.", nameof(nombre));

            try
            {
                return G19_BuscarCategoriaPorNombreRecursivo(nombre.Trim(), 0);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error al buscar la categoría: " + ex.Message, ex);
            }
        }

        private G19_Categoria G19_BuscarCategoriaPorNombreRecursivo(string nombre, int indice)
        {
            if (indice >= G19_contadorCategorias)
                return null;

            if (G19_ListaCategorias[indice] != null &&
                G19_ListaCategorias[indice].nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                return G19_ListaCategorias[indice];
            }

            return G19_BuscarCategoriaPorNombreRecursivo(nombre, indice + 1);
        }
    }
}
