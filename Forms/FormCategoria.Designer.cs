namespace T2
{
    partial class FormCategoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.G19_TxtNombreCategoria = new System.Windows.Forms.TextBox();
            this.G19_BtnConfirmarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // G19_TxtNombreCategoria
            // 
            this.G19_TxtNombreCategoria.Location = new System.Drawing.Point(12, 25);
            this.G19_TxtNombreCategoria.Name = "G19_TxtNombreCategoria";
            this.G19_TxtNombreCategoria.Size = new System.Drawing.Size(150, 20);
            this.G19_TxtNombreCategoria.TabIndex = 1;
            // 
            // G19_BtnConfirmarCategoria
            // 
            this.G19_BtnConfirmarCategoria.Location = new System.Drawing.Point(12, 63);
            this.G19_BtnConfirmarCategoria.Name = "G19_BtnConfirmarCategoria";
            this.G19_BtnConfirmarCategoria.Size = new System.Drawing.Size(150, 23);
            this.G19_BtnConfirmarCategoria.TabIndex = 2;
            this.G19_BtnConfirmarCategoria.Text = "Confirmar";
            this.G19_BtnConfirmarCategoria.UseVisualStyleBackColor = true;
            this.G19_BtnConfirmarCategoria.Click += new System.EventHandler(this.G19_BtnConfirmarCategoria_Click);
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 101);
            this.Controls.Add(this.G19_BtnConfirmarCategoria);
            this.Controls.Add(this.G19_TxtNombreCategoria);
            this.Controls.Add(this.label1);
            this.Name = "FormCategoria";
            this.Text = "FormCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox G19_TxtNombreCategoria;
        private System.Windows.Forms.Button G19_BtnConfirmarCategoria;
    }
}