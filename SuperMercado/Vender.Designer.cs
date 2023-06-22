namespace SuperMercado
{
    partial class Vender
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
            txtMarca = new TextBox();
            txtTipo = new TextBox();
            txtExistencias = new TextBox();
            txtPrecio = new TextBox();
            dgvProducts = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAgregar = new Button();
            dgvLista = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txtCantidad = new TextBox();
            label6 = new Label();
            lblTotalPagar = new Label();
            btnEliminar = new Button();
            txtEfectivo = new TextBox();
            lblDevolucion = new Label();
            btnVender = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // txtMarca
            // 
            txtMarca.Cursor = Cursors.Hand;
            txtMarca.Enabled = false;
            txtMarca.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(353, 299);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(227, 44);
            txtMarca.TabIndex = 24;
            // 
            // txtTipo
            // 
            txtTipo.Cursor = Cursors.Hand;
            txtTipo.Enabled = false;
            txtTipo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipo.Location = new Point(353, 181);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(227, 44);
            txtTipo.TabIndex = 23;
            // 
            // txtExistencias
            // 
            txtExistencias.Cursor = Cursors.Hand;
            txtExistencias.Enabled = false;
            txtExistencias.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtExistencias.Location = new Point(925, 299);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(227, 44);
            txtExistencias.TabIndex = 22;
            // 
            // txtPrecio
            // 
            txtPrecio.Cursor = Cursors.Hand;
            txtPrecio.Enabled = false;
            txtPrecio.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(925, 181);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(227, 44);
            txtPrecio.TabIndex = 21;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.Fixed3D;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Cursor = Cursors.Hand;
            dgvProducts.Location = new Point(28, 482);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 102;
            dgvProducts.RowTemplate.Height = 49;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1124, 388);
            dgvProducts.TabIndex = 20;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Enabled = false;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(678, 295);
            label5.Name = "label5";
            label5.Size = new Size(159, 37);
            label5.TabIndex = 19;
            label5.Text = "Existencia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Enabled = false;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(678, 181);
            label4.Name = "label4";
            label4.Size = new Size(109, 37);
            label4.TabIndex = 18;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Enabled = false;
            label3.ForeColor = Color.White;
            label3.Location = new Point(145, 295);
            label3.Name = "label3";
            label3.Size = new Size(99, 41);
            label3.TabIndex = 17;
            label3.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Enabled = false;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 184);
            label2.Name = "label2";
            label2.Size = new Size(268, 37);
            label2.TabIndex = 16;
            label2.Text = "Tipo de Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Century Gothic", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(992, 36);
            label1.Name = "label1";
            label1.Size = new Size(290, 65);
            label1.TabIndex = 15;
            label1.Text = "Productos";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1308, 917);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(188, 58);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvLista
            // 
            dgvLista.AllowUserToAddRows = false;
            dgvLista.AllowUserToDeleteRows = false;
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLista.BackgroundColor = Color.White;
            dgvLista.BorderStyle = BorderStyle.Fixed3D;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Columns.AddRange(new DataGridViewColumn[] { Column6, Column1, Column2, Column3, Column5, Column4 });
            dgvLista.Cursor = Cursors.Hand;
            dgvLista.Location = new Point(1216, 482);
            dgvLista.Name = "dgvLista";
            dgvLista.ReadOnly = true;
            dgvLista.RowHeadersWidth = 102;
            dgvLista.RowTemplate.Height = 49;
            dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLista.Size = new Size(996, 388);
            dgvLista.TabIndex = 26;
            // 
            // Column6
            // 
            Column6.HeaderText = "Codigo";
            Column6.MinimumWidth = 12;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tipo";
            Column1.MinimumWidth = 12;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Marca";
            Column2.MinimumWidth = 12;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio";
            Column3.MinimumWidth = 12;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Cantidad";
            Column5.MinimumWidth = 12;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Total";
            Column4.MinimumWidth = 12;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(1335, 191);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(250, 47);
            txtCantidad.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Enabled = false;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1364, 88);
            label6.Name = "label6";
            label6.Size = new Size(158, 37);
            label6.TabIndex = 28;
            label6.Text = "Cantidad";
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.ForeColor = Color.White;
            lblTotalPagar.Location = new Point(1407, 318);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(81, 41);
            lblTotalPagar.TabIndex = 29;
            lblTotalPagar.Text = "Total";
            lblTotalPagar.Click += lblTotalPagar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1634, 917);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(188, 58);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtEfectivo
            // 
            txtEfectivo.Location = new Point(1770, 191);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(250, 47);
            txtEfectivo.TabIndex = 31;
            txtEfectivo.TextChanged += txtEfectivo_TextChanged;
            // 
            // lblDevolucion
            // 
            lblDevolucion.AutoSize = true;
            lblDevolucion.ForeColor = Color.White;
            lblDevolucion.Location = new Point(1818, 318);
            lblDevolucion.Name = "lblDevolucion";
            lblDevolucion.Size = new Size(167, 41);
            lblDevolucion.TabIndex = 32;
            lblDevolucion.Text = "Devolucion";
            // 
            // btnVender
            // 
            btnVender.Location = new Point(1546, 394);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(188, 58);
            btnVender.TabIndex = 33;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Enabled = false;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1827, 88);
            label7.Name = "label7";
            label7.Size = new Size(134, 37);
            label7.TabIndex = 34;
            label7.Text = "Efectivo";
            label7.Click += label7_Click;
            // 
            // Vender
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(2825, 1146);
            Controls.Add(label7);
            Controls.Add(btnVender);
            Controls.Add(lblDevolucion);
            Controls.Add(txtEfectivo);
            Controls.Add(btnEliminar);
            Controls.Add(lblTotalPagar);
            Controls.Add(label6);
            Controls.Add(txtCantidad);
            Controls.Add(dgvLista);
            Controls.Add(btnAgregar);
            Controls.Add(txtMarca);
            Controls.Add(txtTipo);
            Controls.Add(txtExistencias);
            Controls.Add(txtPrecio);
            Controls.Add(dgvProducts);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Vender";
            Text = "Vender";
            Load += Vender_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMarca;
        private TextBox txtTipo;
        private TextBox txtExistencias;
        private TextBox txtPrecio;
        private DataGridView dgvProducts;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAgregar;
        private DataGridView dgvLista;
        private TextBox txtCantidad;
        private Label label6;
        private Label lblTotalPagar;
        private Button btnEliminar;
        private TextBox txtEfectivo;
        private Label lblDevolucion;
        private Button btnVender;
        private Label label7;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
    }
}