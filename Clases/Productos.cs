using System;
using System.Collections.Generic;
using T2.Entidades;

namespace T2.Clases
{
    public class G19_Productos
    {
        private readonly G19_Categorias _G19_categorias;
        public List<G19_Producto> G19_ListaProductos { get; private set; }

        public G19_Productos(G19_Categorias G19_categorias)
        {
            _G19_categorias = G19_categorias;
            G19_ListaProductos = new List<G19_Producto>();
        }

        public int G19_ObtenerCantidadProductos()
        {
            return G19_ListaProductos.Count;
        }

        public void G19_CrearProducto(string nombre, int stock, double precio, int categoriaId)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del producto no puede estar vacío.", nameof(nombre));

            if (stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.", nameof(stock));

            if (precio < 0)
                throw new ArgumentException("El precio no puede ser negativo.", nameof(precio));

            if (categoriaId != -1 && _G19_categorias.G19_BuscarCategoriaPorId(categoriaId) == null)
                throw new ArgumentException("Id de categoría inválido. Use -1 para sin categoría.", nameof(categoriaId));

            if (G19_ListaProductos.Count >= 100)
                throw new InvalidOperationException("No se pueden agregar más productos. Límite alcanzado (100).");

            var G19_producto = new G19_Producto(nombre, stock, precio, categoriaId);
            int G19_nextId = 1;
            for (int i = 0; i < G19_ListaProductos.Count; i++)
            {
                if (G19_ListaProductos[i].G19_id >= G19_nextId)
                    G19_nextId = G19_ListaProductos[i].G19_id + 1;
            }
            G19_producto.G19_id = G19_nextId;
            G19_ListaProductos.Add(G19_producto);
        }

        public void G19_EditarProducto(int id, string nombre, int stock, double precio, int categoriaId)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del producto no puede estar vacío.", nameof(nombre));

            if (stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.", nameof(stock));

            if (precio < 0)
                throw new ArgumentException("El precio no puede ser negativo.", nameof(precio));

            if (categoriaId != -1 && _G19_categorias.G19_BuscarCategoriaPorId(categoriaId) == null)
                throw new ArgumentException("Id de categoría inválido. Use -1 para sin categoría.", nameof(categoriaId));

            var G19_producto = G19_BuscarProductoPorId(id);
            if (G19_producto == null)
                throw new ArgumentException("No se puede editar producto no existente.", nameof(id));

            G19_producto.G19_nombre = nombre;
            G19_producto.G19_stock = stock;
            G19_producto.G19_precio = precio;
            G19_producto.G19_categoria_id = categoriaId;
        }

        public void G19_EliminarProducto(int id)
        {
            var G19_producto = G19_BuscarProductoPorId(id);
            
            if (G19_producto == null)
                throw new ArgumentOutOfRangeException(nameof(id), "No se puede eliminar producto no existente.");

            G19_ListaProductos.Remove(G19_producto);
        }

        public G19_Producto G19_BuscarProductoPorId(int id)
        {
            for (int i = 0; i < G19_ListaProductos.Count; i++)
            {
                if (G19_ListaProductos[i].G19_id == id)
                    return G19_ListaProductos[i];
            }
            return null;
        }

        public G19_Producto G19_BuscarProductoPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre de búsqueda no puede estar vacío.", nameof(nombre));

            try
            {
                return G19_BuscarProductoPorNombreRecursivo(nombre.Trim(), 0);
            }
            catch (Exception G19_ex)
            {
                throw new InvalidOperationException("Error al buscar el producto: " + G19_ex.Message, G19_ex);
            }
        }

        private G19_Producto G19_BuscarProductoPorNombreRecursivo(string nombre, int indice)
        {
            if (indice >= G19_ListaProductos.Count)
                return null;

            if (G19_ListaProductos[indice] != null &&
                G19_ListaProductos[indice].G19_nombre.Contains(nombre))
            {
                return G19_ListaProductos[indice];
            }

            return G19_BuscarProductoPorNombreRecursivo(nombre, indice + 1);
        }
    }
}
