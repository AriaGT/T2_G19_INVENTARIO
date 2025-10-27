using System;
using System.Collections.Generic;
using T2.Entidades;

namespace T2.Clases
{
    public class G19_Categorias
    {
        public List<G19_Categoria> G19_ListaCategorias { get; private set; }

        public G19_Categorias()
        {
            G19_ListaCategorias = new List<G19_Categoria>();
        }

        public int G19_ObtenerCantidadCategorias()
        {
            return G19_ListaCategorias.Count;
        }

        public void G19_CrearCategoria(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.", nameof(name));

            if (G19_ListaCategorias.Count >= 100)
                throw new InvalidOperationException("No se pueden agregar más categorías. Límite alcanzado (100).");

            int G19_nextId = G19_ListaCategorias.Count + 1;
            var G19_categoria = new G19_Categoria(G19_nextId, name);
            G19_ListaCategorias.Add(G19_categoria);
        }

        public void G19_EditarCategoria(int id, string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.", nameof(newName));

            var G19_categoria = G19_BuscarCategoriaPorId(id);
            if (G19_categoria == null)
                throw new ArgumentException("No se puede editar categoría no existente.", nameof(id));

            G19_categoria.G19_nombre = newName;
        }

        public void G19_EliminarCategoria(int id)
        {
            var G19_categoria = G19_BuscarCategoriaPorId(id);
            
            if (G19_categoria == null)
                throw new ArgumentException("No se puede eliminar categoría no existente.", nameof(id));

            G19_ListaCategorias.Remove(G19_categoria);
        }

        public G19_Categoria G19_BuscarCategoriaPorId(int id)
        {
            for (int i = 0; i < G19_ListaCategorias.Count; i++)
            {
                if (G19_ListaCategorias[i].G19_id == id)
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
            catch (Exception G19_ex)
            {
                throw new InvalidOperationException("Error al buscar la categoría: " + G19_ex.Message, G19_ex);
            }
        }

        private G19_Categoria G19_BuscarCategoriaPorNombreRecursivo(string nombre, int indice)
        {
            if (indice >= G19_ListaCategorias.Count)
                return null;

            if (G19_ListaCategorias[indice] != null &&
                G19_ListaCategorias[indice].G19_nombre.Contains(nombre))
            {
                return G19_ListaCategorias[indice];
            }

            return G19_BuscarCategoriaPorNombreRecursivo(nombre, indice + 1);
        }
    }
}
