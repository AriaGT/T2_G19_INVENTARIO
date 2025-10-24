namespace T2
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabStock = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.G19_TxtBoxCategoriaStock = new System.Windows.Forms.TextBox();
            this.G19_BtnStock = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.G19_BtnBuscar = new System.Windows.Forms.Button();
            this.G19_TxtBoxBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.G19_DgvProductos = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.G19_BtnEliminarProducto = new System.Windows.Forms.Button();
            this.G19_BtnEditarProducto = new System.Windows.Forms.Button();
            this.G19_BtnCrearProducto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.G_19_Tbcontrol = new System.Windows.Forms.TabControl();
            this.tabCategorias = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.G19_DgvCategorias = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.G19_BtnEliminarCategoria = new System.Windows.Forms.Button();
            this.G19_BtnEditarCategoria = new System.Windows.Forms.Button();
            this.G19_BtnCrearCategoria = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.G19_TxtBuscarCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabStock.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabBusqueda.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G19_DgvProductos)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.G_19_Tbcontrol.SuspendLayout();
            this.tabCategorias.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.G19_DgvCategorias)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStock
            // 
            this.tabStock.Controls.Add(this.groupBox3);
            this.tabStock.Location = new System.Drawing.Point(4, 22);
            this.tabStock.Name = "tabStock";
            this.tabStock.Size = new System.Drawing.Size(672, 424);
            this.tabStock.TabIndex = 3;
            this.tabStock.Text = "Stock";
            this.tabStock.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.G19_TxtBoxCategoriaStock);
            this.groupBox3.Controls.Add(this.G19_BtnStock);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(98, 44);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(320, 261);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stock total por categoría";
            // 
            // G19_TxtBoxCategoriaStock
            // 
            this.G19_TxtBoxCategoriaStock.Location = new System.Drawing.Point(134, 89);
            this.G19_TxtBoxCategoriaStock.Margin = new System.Windows.Forms.Padding(2);
            this.G19_TxtBoxCategoriaStock.Name = "G19_TxtBoxCategoriaStock";
            this.G19_TxtBoxCategoriaStock.Size = new System.Drawing.Size(127, 20);
            this.G19_TxtBoxCategoriaStock.TabIndex = 2;
            // 
            // G19_BtnStock
            // 
            this.G19_BtnStock.Location = new System.Drawing.Point(123, 150);
            this.G19_BtnStock.Margin = new System.Windows.Forms.Padding(2);
            this.G19_BtnStock.Name = "G19_BtnStock";
            this.G19_BtnStock.Size = new System.Drawing.Size(80, 19);
            this.G19_BtnStock.TabIndex = 1;
            this.G19_BtnStock.Text = "Calcular stock";
            this.G19_BtnStock.UseVisualStyleBackColor = true;
            this.G19_BtnStock.Click += new System.EventHandler(this.G19_BtnStock_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Categoría:";
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.Controls.Add(this.groupBox2);
            this.tabBusqueda.Location = new System.Drawing.Point(4, 22);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Size = new System.Drawing.Size(672, 424);
            this.tabBusqueda.TabIndex = 2;
            this.tabBusqueda.Text = "Busqueda";
            this.tabBusqueda.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.G19_BtnBuscar);
            this.groupBox2.Controls.Add(this.G19_TxtBoxBuscar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(101, 51);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(323, 227);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda de producto por nombre";
            // 
            // G19_BtnBuscar
            // 
            this.G19_BtnBuscar.Location = new System.Drawing.Point(128, 140);
            this.G19_BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.G19_BtnBuscar.Name = "G19_BtnBuscar";
            this.G19_BtnBuscar.Size = new System.Drawing.Size(56, 19);
            this.G19_BtnBuscar.TabIndex = 2;
            this.G19_BtnBuscar.Text = "Buscar";
            this.G19_BtnBuscar.UseVisualStyleBackColor = true;
            this.G19_BtnBuscar.Click += new System.EventHandler(this.G19_BtnBuscar_Click);
            // 
            // G19_TxtBoxBuscar
            // 
            this.G19_TxtBoxBuscar.Location = new System.Drawing.Point(148, 72);
            this.G19_TxtBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.G19_TxtBoxBuscar.Name = "G19_TxtBoxBuscar";
            this.G19_TxtBoxBuscar.Size = new System.Drawing.Size(97, 20);
            this.G19_TxtBoxBuscar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre:";
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.panel5);
            this.tabProductos.Location = new System.Drawing.Point(4, 22);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Size = new System.Drawing.Size(672, 424);
            this.tabProductos.TabIndex = 4;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.G19_DgvProductos);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(672, 424);
            this.panel5.TabIndex = 14;
            // 
            // G19_DgvProductos
            // 
            this.G19_DgvProductos.AllowUserToAddRows = false;
            this.G19_DgvProductos.AllowUserToDeleteRows = false;
            this.G19_DgvProductos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.G19_DgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.G19_DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.G19_DgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colPrecio,
            this.colStock,
            this.colCategoria});
            this.G19_DgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.G19_DgvProductos.Location = new System.Drawing.Point(0, 0);
            this.G19_DgvProductos.Name = "G19_DgvProductos";
            this.G19_DgvProductos.ReadOnly = true;
            this.G19_DgvProductos.RowHeadersVisible = false;
            this.G19_DgvProductos.Size = new System.Drawing.Size(456, 424);
            this.G19_DgvProductos.TabIndex = 14;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.G19_BtnEliminarProducto);
            this.panel3.Controls.Add(this.G19_BtnEditarProducto);
            this.panel3.Controls.Add(this.G19_BtnCrearProducto);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(456, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(216, 424);
            this.panel3.TabIndex = 13;
            // 
            // G19_BtnEliminarProducto
            // 
            this.G19_BtnEliminarProducto.Location = new System.Drawing.Point(113, 48);
            this.G19_BtnEliminarProducto.Name = "G19_BtnEliminarProducto";
            this.G19_BtnEliminarProducto.Size = new System.Drawing.Size(95, 23);
            this.G19_BtnEliminarProducto.TabIndex = 14;
            this.G19_BtnEliminarProducto.Text = "Eliminar";
            this.G19_BtnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // G19_BtnEditarProducto
            // 
            this.G19_BtnEditarProducto.Location = new System.Drawing.Point(8, 48);
            this.G19_BtnEditarProducto.Name = "G19_BtnEditarProducto";
            this.G19_BtnEditarProducto.Size = new System.Drawing.Size(95, 23);
            this.G19_BtnEditarProducto.TabIndex = 13;
            this.G19_BtnEditarProducto.Text = "Editar";
            this.G19_BtnEditarProducto.UseVisualStyleBackColor = true;
            // 
            // G19_BtnCrearProducto
            // 
            this.G19_BtnCrearProducto.Location = new System.Drawing.Point(8, 8);
            this.G19_BtnCrearProducto.Name = "G19_BtnCrearProducto";
            this.G19_BtnCrearProducto.Size = new System.Drawing.Size(200, 35);
            this.G19_BtnCrearProducto.TabIndex = 12;
            this.G19_BtnCrearProducto.Text = "Crear Producto";
            this.G19_BtnCrearProducto.UseVisualStyleBackColor = true;
            this.G19_BtnCrearProducto.Click += new System.EventHandler(this.G19_BtnCrearProducto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar por nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 100);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(7, 192);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 12, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(196, 88);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenamiento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Descendente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ascendente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todas"});
            this.comboBox1.Location = new System.Drawing.Point(7, 156);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtrar por categoría";
            // 
            // G_19_Tbcontrol
            // 
            this.G_19_Tbcontrol.Controls.Add(this.tabCategorias);
            this.G_19_Tbcontrol.Controls.Add(this.tabProductos);
            this.G_19_Tbcontrol.Controls.Add(this.tabBusqueda);
            this.G_19_Tbcontrol.Controls.Add(this.tabStock);
            this.G_19_Tbcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.G_19_Tbcontrol.Location = new System.Drawing.Point(0, 0);
            this.G_19_Tbcontrol.Name = "G_19_Tbcontrol";
            this.G_19_Tbcontrol.SelectedIndex = 0;
            this.G_19_Tbcontrol.Size = new System.Drawing.Size(680, 450);
            this.G_19_Tbcontrol.TabIndex = 1;
            // 
            // tabCategorias
            // 
            this.tabCategorias.Controls.Add(this.panel1);
            this.tabCategorias.Location = new System.Drawing.Point(4, 22);
            this.tabCategorias.Name = "tabCategorias";
            this.tabCategorias.Size = new System.Drawing.Size(672, 424);
            this.tabCategorias.TabIndex = 5;
            this.tabCategorias.Text = "Categorías";
            this.tabCategorias.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 424);
            this.panel1.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.G19_DgvCategorias);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(672, 424);
            this.panel4.TabIndex = 14;
            // 
            // G19_DgvCategorias
            // 
            this.G19_DgvCategorias.AllowUserToAddRows = false;
            this.G19_DgvCategorias.AllowUserToDeleteRows = false;
            this.G19_DgvCategorias.BackgroundColor = System.Drawing.SystemColors.Window;
            this.G19_DgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.G19_DgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.G19_DgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.G19_DgvCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.G19_DgvCategorias.Location = new System.Drawing.Point(0, 0);
            this.G19_DgvCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.G19_DgvCategorias.Name = "G19_DgvCategorias";
            this.G19_DgvCategorias.ReadOnly = true;
            this.G19_DgvCategorias.RowHeadersVisible = false;
            this.G19_DgvCategorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.G19_DgvCategorias.Size = new System.Drawing.Size(456, 424);
            this.G19_DgvCategorias.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.G19_BtnEliminarCategoria);
            this.panel2.Controls.Add(this.G19_BtnEditarCategoria);
            this.panel2.Controls.Add(this.G19_BtnCrearCategoria);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.G19_TxtBuscarCategoria);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(456, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(216, 424);
            this.panel2.TabIndex = 15;
            // 
            // G19_BtnEliminarCategoria
            // 
            this.G19_BtnEliminarCategoria.Location = new System.Drawing.Point(113, 50);
            this.G19_BtnEliminarCategoria.Name = "G19_BtnEliminarCategoria";
            this.G19_BtnEliminarCategoria.Size = new System.Drawing.Size(95, 23);
            this.G19_BtnEliminarCategoria.TabIndex = 16;
            this.G19_BtnEliminarCategoria.Text = "Eliminar";
            this.G19_BtnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // G19_BtnEditarCategoria
            // 
            this.G19_BtnEditarCategoria.Location = new System.Drawing.Point(8, 50);
            this.G19_BtnEditarCategoria.Name = "G19_BtnEditarCategoria";
            this.G19_BtnEditarCategoria.Size = new System.Drawing.Size(95, 23);
            this.G19_BtnEditarCategoria.TabIndex = 15;
            this.G19_BtnEditarCategoria.Text = "Editar";
            this.G19_BtnEditarCategoria.UseVisualStyleBackColor = true;
            // 
            // G19_BtnCrearCategoria
            // 
            this.G19_BtnCrearCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.G19_BtnCrearCategoria.Location = new System.Drawing.Point(8, 8);
            this.G19_BtnCrearCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.G19_BtnCrearCategoria.Name = "G19_BtnCrearCategoria";
            this.G19_BtnCrearCategoria.Size = new System.Drawing.Size(200, 35);
            this.G19_BtnCrearCategoria.TabIndex = 13;
            this.G19_BtnCrearCategoria.Text = "Crear Categoría";
            this.G19_BtnCrearCategoria.UseVisualStyleBackColor = true;
            this.G19_BtnCrearCategoria.Click += new System.EventHandler(this.G19_BtnCrearCategoria_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(6, 129);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(201, 88);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ordenamiento";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 53);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 22);
            this.button3.TabIndex = 3;
            this.button3.Text = "Descendente";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 27);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 22);
            this.button4.TabIndex = 2;
            this.button4.Text = "Ascendente";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // G19_TxtBuscarCategoria
            // 
            this.G19_TxtBuscarCategoria.Location = new System.Drawing.Point(8, 101);
            this.G19_TxtBuscarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.G19_TxtBuscarCategoria.Name = "G19_TxtBuscarCategoria";
            this.G19_TxtBuscarCategoria.Size = new System.Drawing.Size(200, 20);
            this.G19_TxtBuscarCategoria.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Buscar por nombre";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.G_19_Tbcontrol);
            this.Name = "FormPrincipal";
            this.Text = "Administrador de Inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabStock.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabBusqueda.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabProductos.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.G19_DgvProductos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.G_19_Tbcontrol.ResumeLayout(false);
            this.tabCategorias.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.G19_DgvCategorias)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox G19_TxtBoxCategoriaStock;
        private System.Windows.Forms.Button G19_BtnStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabBusqueda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button G19_BtnBuscar;
        private System.Windows.Forms.TextBox G19_TxtBoxBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.TabControl G_19_Tbcontrol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabCategorias;
        private System.Windows.Forms.Button G19_BtnCrearCategoria;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox G19_TxtBuscarCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView G19_DgvCategorias;
        private System.Windows.Forms.Button G19_BtnCrearProducto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridView G19_DgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.Button G19_BtnEliminarProducto;
        private System.Windows.Forms.Button G19_BtnEditarProducto;
        private System.Windows.Forms.Button G19_BtnEliminarCategoria;
        private System.Windows.Forms.Button G19_BtnEditarCategoria;
    }
}

