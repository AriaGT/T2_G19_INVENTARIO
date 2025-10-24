using System;
using System.Linq;
using System.Windows.Forms;
using T2.Clases;

namespace T2
{
    public partial class FormProducto : Form
    {
        private readonly G19_Productos _G19_productos;
        private readonly G19_Categorias _G19_categorias;
        public FormProducto(G19_Categorias G19_categorias, G19_Productos G19_productos)
        {
            InitializeComponent();

            _G19_categorias = G19_categorias;
            _G19_productos = G19_productos;
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

                _G19_productos.G19_CrearProducto(G19_nombre, G19_stock, G19_precio, G19_categoria_id);

                MessageBox.Show("Se guardó el artículo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentOutOfRangeException aex)
            {
                MessageBox.Show(aex.Message, "Valor fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException aex)
            {
                MessageBox.Show(aex.Message, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ioex)
            {
                MessageBox.Show(ioex.Message, "Selección inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G19_BtnConfirmarProducto_Click(object sender, EventArgs e)
        {
            G19_CrearProducto();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            G19_CmbCategoriaProducto.Items.Clear();
            G19_CmbCategoriaProducto.DataSource = _G19_categorias.G19_ListaCategorias.Where(c => c != null).ToList();
            G19_CmbCategoriaProducto.ValueMember = "id";
            G19_CmbCategoriaProducto.DisplayMember = "nombre";
        }
    }
}
