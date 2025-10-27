using System;
using System.Windows.Forms;
using T2.Clases;
using T2.Entidades;

namespace T2
{
    public partial class FormCategoria : Form
    {
        private readonly G19_Categorias _G19_categorias;
        private readonly G19_Categoria _G19_categoriaEditar;
        private readonly bool _G19_esEdicion;

        public FormCategoria(G19_Categorias G19_categorias)
        {
            InitializeComponent();

            _G19_categorias = G19_categorias;
            _G19_esEdicion = false;
        }

        public FormCategoria(G19_Categorias G19_categorias, G19_Categoria categoria)
        {
            InitializeComponent();

            _G19_categorias = G19_categorias;
            _G19_categoriaEditar = categoria;
            _G19_esEdicion = true;

            G19_TxtNombreCategoria.Text = categoria.G19_nombre;
            this.Text = "Editar Categoría";
        }

        private void G19_CrearCategoria()
        {
            try
            {
                string G19_nombre = G19_TxtNombreCategoria.Text.Trim();
                if (string.IsNullOrWhiteSpace(G19_nombre))
                    throw new ArgumentException("Ingrese un nombre válido.", nameof(G19_nombre));

                if (_G19_esEdicion)
                {
                    _G19_categorias.G19_EditarCategoria(_G19_categoriaEditar.G19_id, G19_nombre);
                    MessageBox.Show("Se editó la categoría.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _G19_categorias.G19_CrearCategoria(G19_nombre);
                    MessageBox.Show("Se guardó la categoría.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException G19_aex)
            {
                MessageBox.Show(G19_aex.Message, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception G19_ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + G19_ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G19_BtnConfirmarCategoria_Click(object sender, EventArgs e)
        {
            G19_CrearCategoria();
        }
    }
}
