using System;
using System.Windows.Forms;
using T2.Clases;

namespace T2
{
    public partial class FormCategoria : Form
    {
        private readonly G19_Categorias _G19_categorias;

        public FormCategoria(G19_Categorias G19_categorias)
        {
            InitializeComponent();

            _G19_categorias = G19_categorias;
        }

        private void G19_CrearCategoria()
        {
            try
            {
                string G19_nombre = G19_TxtNombreCategoria.Text.Trim();
                if (string.IsNullOrWhiteSpace(G19_nombre))
                    throw new ArgumentException("Ingrese un nombre válido.", nameof(G19_nombre));

                _G19_categorias.G19_CrearCategoria(G19_nombre);

                MessageBox.Show("Se guardó la categoría.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException aex)
            {
                MessageBox.Show(aex.Message, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G19_BtnConfirmarCategoria_Click(object sender, EventArgs e)
        {
            G19_CrearCategoria();
        }
    }
}
