namespace T2
{
    partial class FormProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.G19_TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.G19_CmbCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.G19_NumPrecioProducto = new System.Windows.Forms.NumericUpDown();
            this.G19_NumStockProducto = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.G19_BtnConfirmarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.G19_NumPrecioProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G19_NumStockProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // G19_TxtNombreProducto
            // 
            this.G19_TxtNombreProducto.Location = new System.Drawing.Point(12, 25);
            this.G19_TxtNombreProducto.Name = "G19_TxtNombreProducto";
            this.G19_TxtNombreProducto.Size = new System.Drawing.Size(150, 20);
            this.G19_TxtNombreProducto.TabIndex = 0;
            // 
            // G19_CmbCategoriaProducto
            // 
            this.G19_CmbCategoriaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.G19_CmbCategoriaProducto.FormattingEnabled = true;
            this.G19_CmbCategoriaProducto.Location = new System.Drawing.Point(12, 178);
            this.G19_CmbCategoriaProducto.Name = "G19_CmbCategoriaProducto";
            this.G19_CmbCategoriaProducto.Size = new System.Drawing.Size(150, 21);
            this.G19_CmbCategoriaProducto.TabIndex = 1;
            // 
            // G19_NumPrecioProducto
            // 
            this.G19_NumPrecioProducto.Location = new System.Drawing.Point(12, 73);
            this.G19_NumPrecioProducto.Name = "G19_NumPrecioProducto";
            this.G19_NumPrecioProducto.Size = new System.Drawing.Size(150, 20);
            this.G19_NumPrecioProducto.TabIndex = 2;
            // 
            // G19_NumStockProducto
            // 
            this.G19_NumStockProducto.Location = new System.Drawing.Point(12, 125);
            this.G19_NumStockProducto.Name = "G19_NumStockProducto";
            this.G19_NumStockProducto.Size = new System.Drawing.Size(150, 20);
            this.G19_NumStockProducto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoría";
            // 
            // G19_BtnConfirmarProducto
            // 
            this.G19_BtnConfirmarProducto.Location = new System.Drawing.Point(12, 220);
            this.G19_BtnConfirmarProducto.Name = "G19_BtnConfirmarProducto";
            this.G19_BtnConfirmarProducto.Size = new System.Drawing.Size(150, 23);
            this.G19_BtnConfirmarProducto.TabIndex = 8;
            this.G19_BtnConfirmarProducto.Text = "Confirmar";
            this.G19_BtnConfirmarProducto.UseVisualStyleBackColor = true;
            this.G19_BtnConfirmarProducto.Click += new System.EventHandler(this.G19_BtnConfirmarProducto_Click);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 264);
            this.Controls.Add(this.G19_BtnConfirmarProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.G19_NumStockProducto);
            this.Controls.Add(this.G19_NumPrecioProducto);
            this.Controls.Add(this.G19_CmbCategoriaProducto);
            this.Controls.Add(this.G19_TxtNombreProducto);
            this.MaximizeBox = false;
            this.Name = "FormProducto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.G19_NumPrecioProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G19_NumStockProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox G19_TxtNombreProducto;
        private System.Windows.Forms.ComboBox G19_CmbCategoriaProducto;
        private System.Windows.Forms.NumericUpDown G19_NumPrecioProducto;
        private System.Windows.Forms.NumericUpDown G19_NumStockProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button G19_BtnConfirmarProducto;
    }
}