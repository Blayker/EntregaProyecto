namespace SuperMercado
{
    partial class Productos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvProducts = new DataGridView();
            btnAgregar = new Button();
            txtPrecio = new TextBox();
            txtExistencias = new TextBox();
            txtTipo = new TextBox();
            txtMarca = new TextBox();
            BtnModificar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Century Gothic", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(851, 40);
            label1.Name = "label1";
            label1.Size = new Size(290, 65);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(264, 185);
            label2.Name = "label2";
            label2.Size = new Size(268, 37);
            label2.TabIndex = 2;
            label2.Text = "Tipo de Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.ForeColor = Color.White;
            label3.Location = new Point(352, 296);
            label3.Name = "label3";
            label3.Size = new Size(99, 41);
            label3.TabIndex = 4;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(885, 182);
            label4.Name = "label4";
            label4.Size = new Size(109, 37);
            label4.TabIndex = 6;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(885, 296);
            label5.Name = "label5";
            label5.Size = new Size(159, 37);
            label5.TabIndex = 8;
            label5.Text = "Existencia";
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
            dgvProducts.Location = new Point(220, 461);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 102;
            dgvProducts.RowTemplate.Height = 49;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1368, 420);
            dgvProducts.TabIndex = 9;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.MediumSlateBlue;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(1719, 504);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(217, 58);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar(Post)";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Cursor = Cursors.Hand;
            txtPrecio.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(1132, 182);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(250, 44);
            txtPrecio.TabIndex = 11;
            // 
            // txtExistencias
            // 
            txtExistencias.Cursor = Cursors.Hand;
            txtExistencias.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtExistencias.Location = new Point(1132, 300);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(250, 44);
            txtExistencias.TabIndex = 12;
            // 
            // txtTipo
            // 
            txtTipo.Cursor = Cursors.Hand;
            txtTipo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipo.Location = new Point(560, 182);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(250, 44);
            txtTipo.TabIndex = 13;
            txtTipo.TextChanged += txtTipo_TextChanged;
            // 
            // txtMarca
            // 
            txtMarca.Cursor = Cursors.Hand;
            txtMarca.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(560, 300);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(250, 44);
            txtMarca.TabIndex = 14;
            // 
            // BtnModificar
            // 
            BtnModificar.BackColor = Color.MediumSlateBlue;
            BtnModificar.Cursor = Cursors.Hand;
            BtnModificar.ForeColor = Color.White;
            BtnModificar.Location = new Point(1719, 628);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(217, 58);
            BtnModificar.TabIndex = 15;
            BtnModificar.Text = "Actualizar(Put)";
            BtnModificar.UseVisualStyleBackColor = false;
            BtnModificar.Click += btnModificar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSlateBlue;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1719, 762);
            button1.Name = "button1";
            button1.Size = new Size(217, 58);
            button1.TabIndex = 16;
            button1.Text = "Borrar(Delete)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(2122, 1001);
            Controls.Add(button1);
            Controls.Add(BtnModificar);
            Controls.Add(txtMarca);
            Controls.Add(txtTipo);
            Controls.Add(txtExistencias);
            Controls.Add(txtPrecio);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProducts);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CustomControls.RJControls.RJTextBox txtExistencia;
        private DataGridView dgvProducts;
        private Button btnAgregar;
        private TextBox txtPrecio;
        private TextBox txtExistencias;
        private TextBox txtTipo;
        private TextBox txtMarca;
        private Button BtnModificar;
        private Button button1;
    }
}