using System;
using System.Linq;
using System.Windows.Forms;
using T2.Clases;
using T2.Entidades;

namespace T2
{
    public partial class FormPrincipal : Form
    {
        private G19_Categorias G19_categorias;
        private G19_Productos G19_productos;
        private int G19_categoriaSeleccionadaId = -1;
        private int G19_productoSeleccionadoId = -1;

        public FormPrincipal()
        {
            InitializeComponent();

            G19_categorias = new G19_Categorias();
            G19_productos = new G19_Productos(G19_categorias);

            G19_DgvProductos.AutoGenerateColumns = false;
            G19_DgvCategorias.AutoGenerateColumns = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            G19_ActualizarSelectorCategorias();
            G19_ActualizarTablas();
            G19_TxtBuscarCategoria.Enabled = G19_categorias.G19_ObtenerCantidadCategorias() > 0;
        }

        private void G19_ActualizarSelectorCategorias()
        {
            G19_CmbCategoriaProducto.DataSource = G19_categorias.G19_ListaCategorias.Where(c => c != null).ToList();
            G19_CmbCategoriaProducto.ValueMember = "G19_id";
            G19_CmbCategoriaProducto.DisplayMember = "G19_nombre";
        }

        private void G19_ActualizarTablas()
        {
            G19_DgvCategorias.Rows.Clear();
            for (int i = 0; i < G19_categorias.G19_ObtenerCantidadCategorias(); i++)
            {
                var G19_categoria = G19_categorias.G19_ListaCategorias[i];
                G19_DgvCategorias.Rows.Add(G19_categoria.G19_id, G19_categoria.G19_nombre);
            }

            G19_DgvProductos.Rows.Clear();
            for (int i = 0; i < G19_productos.G19_ObtenerCantidadProductos(); i++)
            {
                var G19_producto = G19_productos.G19_ListaProductos[i];
                
                string G19_nombreCategoria = "Sin categoría";
                if (G19_producto.G19_categoria_id != -1)
                {
                    var G19_categoria = G19_categorias.G19_BuscarCategoriaPorId(G19_producto.G19_categoria_id);
                    if (G19_categoria != null)
                    {
                        G19_nombreCategoria = G19_categoria.ToString();
                    }
                }

                int G19_rowIndex = G19_DgvProductos.Rows.Add(
                    G19_producto.G19_nombre,
                    G19_producto.G19_precio,
                    G19_producto.G19_stock,
                    G19_nombreCategoria
                );
                G19_DgvProductos.Rows[G19_rowIndex].Tag = G19_producto.G19_id;
            }

            G19_TxtBuscarCategoria.Enabled = G19_categorias.G19_ObtenerCantidadCategorias() > 0;
            G19_categoriaSeleccionadaId = -1;
            G19_productoSeleccionadoId = -1;
        }

        private void G19_BtnStock_Click(object sender, EventArgs e)
        {
            if (G19_CmbCategoriaProducto.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoría para calcular el stock.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int G19_categoriaId = (int)G19_CmbCategoriaProducto.SelectedValue;
            var G19_categoria = G19_categorias.G19_BuscarCategoriaPorId(G19_categoriaId);

            if (G19_categoria == null)
            {
                MessageBox.Show("Categoría no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int G19_stockTotal = G19_CalcularStockRecursivo(G19_categoriaId, 0);

            MessageBox.Show($"Stock total en la categoría '{G19_categoria.G19_nombre}': {G19_stockTotal} unidades.", 
                "Stock por categoría", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private int G19_CalcularStockRecursivo(int G19_categoriaId, int G19_indice)
        {
            
            if (G19_indice >= G19_productos.G19_ListaProductos.Count)
            {
                return 0;
            }

            var G19_producto = G19_productos.G19_ListaProductos[G19_indice];
            int G19_stockActual = 0;

            
            if (G19_producto != null && G19_producto.G19_categoria_id == G19_categoriaId)
            {
                G19_stockActual = G19_producto.G19_stock;
            }

            
            return G19_stockActual + G19_CalcularStockRecursivo(G19_categoriaId, G19_indice + 1);
        }

        private void G19_BtnCrearProducto_Click(object sender, EventArgs e)
        {
            if (G19_categorias.G19_ObtenerCantidadCategorias() == 0)
            {
                MessageBox.Show("Debe crear al menos una categoría antes de agregar productos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormProducto G19_formProducto = new FormProducto(G19_categorias, G19_productos);
            G19_formProducto.ShowDialog();
            G19_ActualizarTablas();
        }

        private void G19_BtnCrearCategoria_Click(object sender, EventArgs e)
        {
            FormCategoria G19_formCategoria = new FormCategoria(G19_categorias);
            G19_formCategoria.ShowDialog();
            G19_ActualizarTablas();
            G19_ActualizarSelectorCategorias();
        }

        private void G19_BtnEditarCategoria_Click(object sender, EventArgs e)
        {
            if (G19_categoriaSeleccionadaId == -1)
            {
                MessageBox.Show("Seleccione una categoría para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var G19_categoria = G19_categorias.G19_BuscarCategoriaPorId(G19_categoriaSeleccionadaId);

            if (G19_categoria == null)
            {
                MessageBox.Show("No se encontró la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormCategoria G19_formCategoria = new FormCategoria(G19_categorias, G19_categoria);
            G19_formCategoria.ShowDialog();
            G19_ActualizarTablas();
            G19_ActualizarSelectorCategorias();
        }

        private void G19_BtnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (G19_categoriaSeleccionadaId == -1)
            {
                MessageBox.Show("Seleccione una categoría para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var G19_categoria = G19_categorias.G19_BuscarCategoriaPorId(G19_categoriaSeleccionadaId);

            if (G19_categoria == null)
            {
                MessageBox.Show("No se encontró la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult G19_resultado = MessageBox.Show($"¿Está seguro que desea eliminar la categoría '{G19_categoria.G19_nombre}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (G19_resultado == DialogResult.Yes)
            {
                try
                {
                    G19_categorias.G19_EliminarCategoria(G19_categoriaSeleccionadaId);
                    MessageBox.Show("Categoría eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    G19_ActualizarTablas();
                    G19_ActualizarSelectorCategorias();
                }
                catch (Exception G19_ex)
                {
                    MessageBox.Show(G19_ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void G19_BtnEditarProducto_Click(object sender, EventArgs e)
        {
            if (G19_productoSeleccionadoId == -1)
            {
                MessageBox.Show("Seleccione un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var G19_producto = G19_productos.G19_BuscarProductoPorId(G19_productoSeleccionadoId);

            if (G19_producto == null)
            {
                MessageBox.Show("No se encontró el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormProducto G19_formProducto = new FormProducto(G19_categorias, G19_productos, G19_producto);
            G19_formProducto.ShowDialog();
            G19_ActualizarTablas();
        }

        private void G19_BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (G19_productoSeleccionadoId == -1)
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var G19_producto = G19_productos.G19_BuscarProductoPorId(G19_productoSeleccionadoId);

            if (G19_producto == null)
            {
                MessageBox.Show("No se encontró el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult G19_resultado = MessageBox.Show($"¿Está seguro que desea eliminar el producto '{G19_producto.G19_nombre}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (G19_resultado == DialogResult.Yes)
            {
                try
                {
                    G19_productos.G19_EliminarProducto(G19_productoSeleccionadoId);
                    MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    G19_ActualizarTablas();
                }
                catch (Exception G19_ex)
                {
                    MessageBox.Show(G19_ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void G19_TxtBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string G19_nombreBusqueda = G19_TxtBuscarCategoria.Text.Trim();

                G19_DgvCategorias.Rows.Clear();
                G19_categoriaSeleccionadaId = -1;

                if (string.IsNullOrWhiteSpace(G19_nombreBusqueda))
                {
                    foreach (var G19_categoria in G19_categorias.G19_ListaCategorias)
                    {
                        if (G19_categoria != null)
                        {
                            G19_DgvCategorias.Rows.Add(G19_categoria.G19_id, G19_categoria.G19_nombre);
                        }
                    }
                }
                else
                {
                    G19_Categoria G19_encontrada = G19_categorias.G19_BuscarCategoriaPorNombre(G19_nombreBusqueda);

                    if (G19_encontrada != null)
                    {
                        G19_DgvCategorias.Rows.Add(G19_encontrada.G19_id, G19_encontrada.G19_nombre);
                    }
                }
            }
            catch (ArgumentException G19_ex)
            {
                MessageBox.Show(G19_ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException G19_ex)
            {
                MessageBox.Show(G19_ex.Message, "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception G19_ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + G19_ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G19_TxtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string G19_nombreBusqueda = G19_TxtBuscarProducto.Text.Trim();

                G19_DgvProductos.Rows.Clear();
                G19_productoSeleccionadoId = -1;

                if (string.IsNullOrWhiteSpace(G19_nombreBusqueda))
                {
                    foreach (var G19_producto in G19_productos.G19_ListaProductos)
                    {
                        if (G19_producto != null)
                        {
                            string G19_nombreCategoria = "Sin categoria";
                            if (G19_producto.G19_categoria_id != -1)
                            {
                                var G19_categoria = G19_categorias.G19_BuscarCategoriaPorId(G19_producto.G19_categoria_id);
                                if (G19_categoria != null)
                                {
                                    G19_nombreCategoria = G19_categoria.ToString();
                                }
                            }

                            int G19_rowIndex = G19_DgvProductos.Rows.Add(
                                G19_producto.G19_nombre,
                                G19_producto.G19_precio,
                                G19_producto.G19_stock,
                                G19_nombreCategoria
                            );
                            G19_DgvProductos.Rows[G19_rowIndex].Tag = G19_producto.G19_id;
                        }
                    }
                }
                else
                {
                    G19_Producto G19_encontrado = G19_productos.G19_BuscarProductoPorNombre(G19_nombreBusqueda);

                    if (G19_encontrado != null)
                    {
                        string G19_nombreCategoria = "Sin categoría";
                        if (G19_encontrado.G19_categoria_id != -1)
                        {
                            var G19_categoria = G19_categorias.G19_BuscarCategoriaPorId(G19_encontrado.G19_categoria_id);
                            if (G19_categoria != null)
                            {
                                G19_nombreCategoria = G19_categoria.ToString();
                            }
                        }

                        int G19_rowIndex = G19_DgvProductos.Rows.Add(
                            G19_encontrado.G19_nombre,
                            G19_encontrado.G19_precio,
                            G19_encontrado.G19_stock,
                            G19_nombreCategoria
                        );
                        G19_DgvProductos.Rows[G19_rowIndex].Tag = G19_encontrado.G19_id;
                    }
                }
            }
            catch (ArgumentException G19_ex)
            {
                MessageBox.Show(G19_ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException G19_ex)
            {
                MessageBox.Show(G19_ex.Message, "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception G19_ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + G19_ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G19_DgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (G19_DgvProductos.Rows[e.RowIndex].Tag != null)
                {
                    G19_productoSeleccionadoId = (int)G19_DgvProductos.Rows[e.RowIndex].Tag;
                }
            }
        }

        private void G19_DgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                G19_categoriaSeleccionadaId = (int)G19_DgvCategorias.Rows[e.RowIndex].Cells[0].Value;
            }
        }

        private void G19_BtnOrdenarCategoriasAscendente_Click(object sender, EventArgs e)
        {
            var G19_lista = G19_categorias.G19_ListaCategorias;
            int G19_n = G19_lista.Count;

            for (int i = 0; i < G19_n - 1; i++)
            {
                for (int j = 0; j < G19_n - i - 1; j++)
                {
                    if (string.Compare(G19_lista[j].G19_nombre, G19_lista[j + 1].G19_nombre, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        var G19_temp = G19_lista[j];
                        G19_lista[j] = G19_lista[j + 1];
                        G19_lista[j + 1] = G19_temp;
                    }
                }
            }

            G19_DgvCategorias.Rows.Clear();
            G19_categoriaSeleccionadaId = -1;
            foreach (var G19_categoria in G19_lista)
            {
                if (G19_categoria != null)
                {
                    G19_DgvCategorias.Rows.Add(G19_categoria.G19_id, G19_categoria.G19_nombre);
                }
            }
        }

        private void G19_BtnOrdenarCategoriasDescendente_Click(object sender, EventArgs e)
        {
            var G19_lista = G19_categorias.G19_ListaCategorias;
            int G19_n = G19_lista.Count;

            for (int i = 0; i < G19_n - 1; i++)
            {
                for (int j = 0; j < G19_n - i - 1; j++)
                {
                    if (string.Compare(G19_lista[j].G19_nombre, G19_lista[j + 1].G19_nombre, StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        var G19_temp = G19_lista[j];
                        G19_lista[j] = G19_lista[j + 1];
                        G19_lista[j + 1] = G19_temp;
                    }
                }
            }

            G19_DgvCategorias.Rows.Clear();
            G19_categoriaSeleccionadaId = -1;
            foreach (var G19_categoria in G19_lista)
            {
                if (G19_categoria != null)
                {
                    G19_DgvCategorias.Rows.Add(G19_categoria.G19_id, G19_categoria.G19_nombre);
                }
            }
        }

        private void G19_BtnOrdenarProductosAscendente_Click(object sender, EventArgs e)
        {
            var G19_lista = G19_productos.G19_ListaProductos;
            int G19_n = G19_lista.Count;

            for (int i = 0; i < G19_n - 1; i++)
            {
                for (int j = 0; j < G19_n - i - 1; j++)
                {
                    if (string.Compare(G19_lista[j].G19_nombre, G19_lista[j + 1].G19_nombre, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        var G19_temp = G19_lista[j];
                        G19_lista[j] = G19_lista[j + 1];
                        G19_lista[j + 1] = G19_temp;
                    }
                }
            }

            G19_DgvProductos.Rows.Clear();
            G19_productoSeleccionadoId = -1;
            foreach (var G19_producto in G19_lista)
            {
                if (G19_producto != null)
                {
                    string G19_nombreCategoria = "Sin categoría";
                    if (G19_producto.G19_categoria_id != -1)
                    {
                        var G19_categoria = G19_categorias.G19_BuscarCategoriaPorId(G19_producto.G19_categoria_id);
                        if (G19_categoria != null)
                        {
                            G19_nombreCategoria = G19_categoria.ToString();
                        }
                    }

                    int G19_rowIndex = G19_DgvProductos.Rows.Add(
                        G19_producto.G19_nombre,
                        G19_producto.G19_precio,
                        G19_producto.G19_stock,
                        G19_nombreCategoria
                    );
                    G19_DgvProductos.Rows[G19_rowIndex].Tag = G19_producto.G19_id;
                }
            }
        }

        private void G19_BtnOrdenarProductosDescendente_Click(object sender, EventArgs e)
        {
            var G19_lista = G19_productos.G19_ListaProductos;
            int G19_n = G19_lista.Count;

            for (int i = 0; i < G19_n - 1; i++)
            {
                for (int j = 0; j < G19_n - i - 1; j++)
                {
                    if (string.Compare(G19_lista[j].G19_nombre, G19_lista[j + 1].G19_nombre, StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        var G19_temp = G19_lista[j];
                        G19_lista[j] = G19_lista[j + 1];
                        G19_lista[j + 1] = G19_temp;
                    }
                }
            }

            G19_DgvProductos.Rows.Clear();
            G19_productoSeleccionadoId = -1;
            foreach (var G19_producto in G19_lista)
            {
                if (G19_producto != null)
                {
                    string G19_nombreCategoria = "Sin categoría";
                    if (G19_producto.G19_categoria_id != -1)
                    {
                        var G19_categoria = G19_categorias.G19_BuscarCategoriaPorId(G19_producto.G19_categoria_id);
                        if (G19_categoria != null)
                        {
                            G19_nombreCategoria = G19_categoria.ToString();
                        }
                    }

                    int G19_rowIndex = G19_DgvProductos.Rows.Add(
                        G19_producto.G19_nombre,
                        G19_producto.G19_precio,
                        G19_producto.G19_stock,
                        G19_nombreCategoria
                    );
                    G19_DgvProductos.Rows[G19_rowIndex].Tag = G19_producto.G19_id;
                }
            }
        }
    }
}
