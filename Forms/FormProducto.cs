using System;
using System.Linq;
using System.Windows.Forms;
using T2.Clases;
using T2.Entidades;

namespace T2
{
    public partial class FormProducto : Form
    {
        private readonly G19_Productos _G19_productos;
        private readonly G19_Categorias _G19_categorias;
        private readonly G19_Producto _G19_productoEditar;
        private readonly bool _G19_esEdicion;

        public FormProducto(G19_Categorias G19_categorias, G19_Productos G19_productos)
        {
            InitializeComponent();

            _G19_categorias = G19_categorias;
            _G19_productos = G19_productos;
            _G19_esEdicion = false;
        }

        public FormProducto(G19_Categorias G19_categorias, G19_Productos G19_productos, G19_Producto producto)
        {
            InitializeComponent();

            _G19_categorias = G19_categorias;
            _G19_productos = G19_productos;
            _G19_productoEditar = producto;
            _G19_esEdicion = true;
        }

        private void G19_CrearProducto()
        {
            try
            {
                string G19_nombre = G19_TxtNombreProducto.Text.Trim();
                if (string.IsNullOrWhiteSpace(G19_nombre))
                    throw new ArgumentException("Ingrese un nombre válido.", nameof(G19_nombre));

                int G19_precio = (int)G19_NumPrecioProducto.Value;
                if (G19_precio < 0)
                    throw new ArgumentOutOfRangeException(nameof(G19_precio), "El precio no puede ser negativo.");

                int G19_stock = (int)G19_NumStockProducto.Value;
                if (G19_stock < 0)
                    throw new ArgumentOutOfRangeException(nameof(G19_stock), "La cantidad no puede ser negativa.");

                if (G19_CmbCategoriaProducto.SelectedValue == null)
                    throw new InvalidOperationException($"Seleccione una categoría válida.");
                int G19_categoria_id = (int)G19_CmbCategoriaProducto.SelectedValue;

                if (_G19_esEdicion)
                {
                    _G19_productos.G19_EditarProducto(_G19_productoEditar.G19_id, G19_nombre, G19_stock, G19_precio, G19_categoria_id);
                    MessageBox.Show("Se editó el artículo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _G19_productos.G19_CrearProducto(G19_nombre, G19_stock, G19_precio, G19_categoria_id);
                    MessageBox.Show("Se guardó el artículo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentOutOfRangeException G19_aex)
            {
                MessageBox.Show(G19_aex.Message, "Valor fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException G19_aex)
            {
                MessageBox.Show(G19_aex.Message, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException G19_ioex)
            {
                MessageBox.Show(G19_ioex.Message, "Selección inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception G19_ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + G19_ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G19_BtnConfirmarProducto_Click(object sender, EventArgs e)
        {
            G19_CrearProducto();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            G19_CmbCategoriaProducto.DataSource = _G19_categorias.G19_ListaCategorias.Where(c => c != null).ToList();
            G19_CmbCategoriaProducto.ValueMember = "G19_id";
            G19_CmbCategoriaProducto.DisplayMember = "G19_nombre";

            if (_G19_esEdicion && _G19_productoEditar != null)
            {
                G19_TxtNombreProducto.Text = _G19_productoEditar.G19_nombre;
                G19_NumPrecioProducto.Value = (decimal)_G19_productoEditar.G19_precio;
                G19_NumStockProducto.Value = _G19_productoEditar.G19_stock;
                G19_CmbCategoriaProducto.SelectedValue = _G19_productoEditar.G19_categoria_id;
                this.Text = "Editar Producto";
            }
            else
            {
                this.Text = "Crear Producto";
            }
        }
    }
}
