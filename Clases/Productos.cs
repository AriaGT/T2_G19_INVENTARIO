using System;
using System.Linq;
using T2.Entidades;

namespace T2.Clases
{
    public class G19_Productos
    {
        private readonly G19_Categorias _G19_categorias;
        public G19_Producto[] G19_ListaProductos { get; private set; }
        private int G19_contadorProductos = 0;

        public G19_Productos(G19_Categorias G19_categorias)
        {
            _G19_categorias = G19_categorias;
            G19_ListaProductos = new G19_Producto[100];
        }

        public int G19_ObtenerCantidadProductos()
        {
            return G19_contadorProductos;
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

            if (G19_contadorProductos >= 100)
                throw new InvalidOperationException("No se pueden agregar más productos. Límite alcanzado (100).");

            var G19_producto = new G19_Producto(nombre, stock, precio, categoriaId);
            int G19_nextId = 1;
            for (int i = 0; i < G19_contadorProductos; i++)
            {
                if (G19_ListaProductos[i].id >= G19_nextId)
                    G19_nextId = G19_ListaProductos[i].id + 1;
            }
            G19_producto.id = G19_nextId;
            G19_ListaProductos[G19_contadorProductos] = G19_producto;
            G19_contadorProductos++;
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

            G19_producto.nombre = nombre;
            G19_producto.stock = stock;
            G19_producto.precio = precio;
            G19_producto.categoria_id = categoriaId;
        }

        public void G19_EliminarProducto(int id)
        {
            int index = -1;
            for (int i = 0; i < G19_contadorProductos; i++)
            {
                if (G19_ListaProductos[i].id == id)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
                throw new ArgumentOutOfRangeException(nameof(id), "No se puede eliminar producto no existente.");

            for (int i = index; i < G19_contadorProductos - 1; i++)
            {
                G19_ListaProductos[i] = G19_ListaProductos[i + 1];
            }

            G19_ListaProductos[G19_contadorProductos - 1] = null;
            G19_contadorProductos--;
        }

        public G19_Producto G19_BuscarProductoPorId(int id)
        {
            for (int i = 0; i < G19_contadorProductos; i++)
            {
                if (G19_ListaProductos[i].id == id)
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
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error al buscar la categoría: " + ex.Message, ex);
            }
        }

        private G19_Producto G19_BuscarProductoPorNombreRecursivo(string nombre, int indice)
        {
            if (indice >= G19_contadorProductos)
                return null;

            if (G19_ListaProductos[indice] != null &&
                G19_ListaProductos[indice].nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                return G19_ListaProductos[indice];
            }

            return G19_BuscarProductoPorNombreRecursivo(nombre, indice + 1);
        }
    }
}
