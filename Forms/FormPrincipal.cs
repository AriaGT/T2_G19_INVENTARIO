using System;
using System.Linq;
using System.Windows.Forms;
using T2.Clases;

namespace T2
{
    public partial class FormPrincipal : Form
    {
        Listado listado = new Listado(100);
        private G19_Categorias G19_categorias;
        private G19_Productos G19_productos;

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
            G19_ActualizarTablas();
            G19_TxtBuscarCategoria.Enabled = G19_categorias.G19_ObtenerCantidadCategorias() > 0;
        }

        private void G19_ActualizarTablas()
        {
            G19_DgvCategorias.Rows.Clear();
            for (int i = 0; i < G19_categorias.G19_ObtenerCantidadCategorias(); i++)
            {
                var categoria = G19_categorias.G19_ListaCategorias[i];
                G19_DgvCategorias.Rows.Add(categoria.id, categoria.nombre);
            }

            G19_DgvProductos.Rows.Clear();
            for (int i = 0; i < G19_productos.G19_ObtenerCantidadProductos(); i++)
            {
                var producto = G19_productos.G19_ListaProductos[i];
                
                string nombreCategoria = "Sin categoría";
                if (producto.categoria_id != -1)
                {
                    var categoria = G19_categorias.G19_BuscarCategoriaPorId(producto.categoria_id);
                    if (categoria != null)
                    {
                        nombreCategoria = categoria.ToString();
                    }
                }

                G19_DgvProductos.Rows.Add(
                    producto.nombre,
                    producto.precio,
                    producto.stock,
                    nombreCategoria
                );
            }

            G19_TxtBuscarCategoria.Enabled = G19_categorias.G19_ObtenerCantidadCategorias() > 0;
        }

        private void G19_BtnBuscar_Click(object sender, EventArgs e)
        {
            string nombreBusqueda = G19_TxtBoxBuscar.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombreBusqueda))
            {
                MessageBox.Show("Ingrese el nombre a buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Inventario encontrado = listado.BuscarPorNombre(nombreBusqueda);
            if (encontrado != null)
            {
                MessageBox.Show($"Encontrado:\nNombre: {encontrado.nombre}\nCategoría: {encontrado.categoria}\nCantidad: {encontrado.cantidad}\nPrecio: {encontrado.precio}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró el producto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void G19_BtnStock_Click(object sender, EventArgs e)
        {
            string categoria = G19_TxtBoxCategoriaStock.Text.Trim();
            if (string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Ingrese una categoría para calcular el stock total.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int total = listado.CalcularStockPorCategoria(categoria);
            MessageBox.Show($"Stock total en la categoría '{categoria}': {total} unidades.", "Stock por categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void G19_BtnOrdenarAsc_Click(object sender, EventArgs e)
        {
            Inventario[] listaOrdenada = listado.ObtenerInventirio();
            
            G19_DgvProductos.Rows.Clear();
            foreach (var inventario in listaOrdenada)
            {
                if (inventario != null)
                {
                    G19_DgvProductos.Rows.Add(
                        inventario.nombre,
                        inventario.precio,
                        inventario.cantidad,
                        inventario.categoria
                    );
                }
            }
        }

        private void G19_BtnOrdenarDesc_Click(object sender, EventArgs e)
        {
            Inventario[] listaOrdenadaDesc = listado.ObtenerInventirioDescendente();
            
            G19_DgvProductos.Rows.Clear();
            foreach (var inventario in listaOrdenadaDesc)
            {
                if (inventario != null)
                {
                    G19_DgvProductos.Rows.Add(
                        inventario.nombre,
                        inventario.precio,
                        inventario.cantidad,
                        inventario.categoria
                    );
                }
            }
        }

        private void G19_BtnCrearProducto_Click(object sender, EventArgs e)
        {
            if (G19_categorias.G19_ObtenerCantidadCategorias() == 0)
            {
                MessageBox.Show("Debe crear al menos una categoría antes de agregar productos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormProducto formProducto = new FormProducto(G19_categorias, G19_productos);
            formProducto.ShowDialog();
            G19_ActualizarTablas();
        }

        private void G19_BtnCrearCategoria_Click(object sender, EventArgs e)
        {
            FormCategoria formCategoria = new FormCategoria(G19_categorias);
            formCategoria.ShowDialog();
            G19_ActualizarTablas();
        }
    }
}
